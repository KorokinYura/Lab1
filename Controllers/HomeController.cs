﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using Lab1.Data;
using Lab1.Models.ViewModels;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Authorization;

namespace Lab1.Controllers
{
    public class HomeController : Controller
    {
        private readonly ApplicationDbContext _db;

        public HomeController(ApplicationDbContext db)
        {
            _db = db;
        }

        public IActionResult Index()
        {
            return RedirectToAction("ViewAlternatives");
        }

        public IActionResult ViewAlternatives()
        {
            return View(new ViewAlternativesViewModel
            {
                Alternatives = _db.Alternatives.OrderBy(a => a.AName),
                Criterions = _db.Criterions,
                Marks = _db.Marks,
                Vectors = _db.Vectors
            });
        }

        public IActionResult Alternative(int idAlt = 0)
        {
            Alternative alternative = new Alternative();

            if (idAlt != 0)
                alternative = _db.Alternatives.FirstOrDefault(a => a.IdAlt == idAlt);
            return View(new AlternativeViewModel
            {
                Alternative = alternative,
                Alternatives = _db.Alternatives,
                Criterions = _db.Criterions,
                Marks = _db.Marks,
                Vectors = _db.Vectors
            });
        }

        [HttpPost]
        public IActionResult Alternative(int idAlt, string aName, List<int> idMarks)
        {
            Alternative alternative = new Alternative() { AName = aName };

            if (idAlt == 0)
            {
                _db.Alternatives.Add(alternative);
                _db.SaveChanges();

                foreach (var idMark in idMarks)
                {
                    _db.Vectors.Add(new Vector()
                    {
                        IdAlt = alternative.IdAlt,
                        IdMark = idMark
                    });
                }

                _db.SaveChanges();
            }
            else
            {
                _db.Alternatives.Remove(_db.Alternatives.First(a => a.IdAlt == idAlt));

                _db.Alternatives.Add(alternative);
                _db.SaveChanges();

                foreach (var idMark in idMarks)
                {
                    _db.Vectors.Add(new Vector()
                    {
                        IdAlt = alternative.IdAlt,
                        IdMark = idMark
                    });
                }

                _db.SaveChanges();
            }

            return RedirectToAction("ViewAlternatives");
        }

        public IActionResult RemoveAlternative(int IdAlt)
        {
            _db.Alternatives.Remove(_db.Alternatives.First(c => c.IdAlt == IdAlt));
            _db.SaveChanges();
            return RedirectToAction("ViewAlternatives");
        }

        public IActionResult ViewCriterions()
        {
            return View(_db.Criterions);
        }

        public IActionResult Criterion(int idCrit = 0)
        {
            Criterion criterion = null;

            if (idCrit != 0)
                criterion = _db.Criterions.FirstOrDefault(c => c.IdCrit == idCrit);
            return View(new CriterionViewModel
            {
                Criterion = criterion,
                Criterions = _db.Criterions
            });
        }

        [HttpPost]
        public IActionResult Criterion(Criterion criterion)
        {
            if (criterion.IdCrit == 0 && criterion.CName != null)
            {
                if (_db.Criterions.FirstOrDefault(c => c.CName == criterion.CName) == null)
                    _db.Criterions.Add(criterion);
            }
            else
                _db.Criterions.Update(criterion);

            _db.SaveChanges();
            return RedirectToAction("ViewCriterions");
        }

        public IActionResult RemoveCriterion(int idCrit)
        {
            _db.Criterions.Remove(_db.Criterions.First(c => c.IdCrit == idCrit));
            _db.SaveChanges();
            return RedirectToAction("ViewCriterions");
        }

        public IActionResult ViewMarks()
        {
            return View(new ViewMarksViewModel
            {
                Marks = _db.Marks,
                Criterions = _db.Criterions
            });
        }

        public IActionResult Mark(int idMark = 0)
        {
            Mark mark = null;

            if (idMark != 0)
                mark = _db.Marks.FirstOrDefault(m => m.IdMark == idMark);
            return View(new MarkViewModel
            {
                Mark = mark,
                Marks = _db.Marks,
                Criterions = _db.Criterions
            });
        }

        [HttpPost]
        public IActionResult Mark(Criterion criterion, Mark mark)
        {
            Criterion crit = _db.Criterions.First(c => c.IdCrit == criterion.IdCrit);
            mark.IdCrit = crit.IdCrit;

            if (mark.IdMark == 0)
                _db.Marks.Add(mark);
            else
                _db.Marks.Update(mark);

            _db.SaveChanges();
            return RedirectToAction("ViewMarks");
        }

        public IActionResult RemoveMark(int idMark)
        {
            _db.Marks.Remove(_db.Marks.First(m => m.IdMark == idMark));
            _db.SaveChanges();
            return RedirectToAction("ViewMarks");
        }




        // lab 2
        [Authorize]
        public IActionResult LinearConvolution()
        {
            return View(new LinearConvolution
            {
                Alternatives = _db.Alternatives
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult LinearConvolution(string floor, string metro, string heat)
        {
            var vectList = FormList().OrderBy(v => v.Alternative.AName).ToList();

            var dict = GetCritValues(vectList, floor, metro, heat);

            return View("ShowLinearConvolution", new LinearConvolutionViewModel
            {
                Vectors = vectList,
                AltValues = dict
            });
        }

        [Authorize]
        public Dictionary<string, int> GetCritValues(List<Vector> vectList, string floor, string metro, string heat)
        {
            var altValueDict = new Dictionary<string, int>();

            foreach (var alt in _db.Alternatives)
            {
                altValueDict.Add(alt.AName, 0);
            }

            int curVal = 0;
            int maxVal = 0;
            int minVal = 0;
            var altNames = new List<string>();
            bool max = false;

            foreach (var crit in _db.Criterions)
            {
                altNames = altNames.Distinct().ToList();

                foreach (var alt in altNames)
                {
                    altValueDict[alt]++;
                }

                altNames = new List<string>();

                if (crit.CName != "Внешний вид" && crit.CName != "Автономное отопление")
                {
                    if ((crit.OptimType == "Max" && crit.CName != "Этаж") || floor == "high")
                    {
                        max = true;
                        maxVal = int.Parse(vectList.Where(v => v.Mark.Criterion.CName == crit.CName).Max(v => v.Mark.MName));
                    }
                    else
                    {
                        max = false;
                        minVal = int.Parse(vectList.Where(v => v.Mark.Criterion.CName == crit.CName).Min(v => v.Mark.MName));
                    }
                }

                foreach (var alt in _db.Alternatives)
                {
                    if (crit.CName != "Внешний вид" && crit.CName != "Автономное отопление")
                    {
                        curVal = int.Parse(vectList.Where(v => v.Alternative.AName == alt.AName)
                            .First(v => v.Mark.Criterion.CName == crit.CName).Mark.MName);
                    }
                    else
                    {
                        string temp = vectList.Where(v => v.Alternative.AName == alt.AName)
                            .First(v => v.Mark.Criterion.CName == crit.CName).Mark.MName;

                        if (temp == "Красиво")
                            altNames.Add(alt.AName);
                        if (temp == "Есть" && heat != "notImportant")
                            altNames.Add(alt.AName);
                        continue;
                    }

                    if (!(crit.CName == "Расстояние от метро" && metro == "notImportant"))
                        if (max)
                        {
                            if (curVal == maxVal)
                            {
                                altNames.Add(alt.AName);
                            }

                        }
                        else
                        {
                            if (curVal == minVal)
                            {
                                altNames.Add(alt.AName);
                            }
                        }
                }
            }

            return altValueDict;
        }

        [Authorize]
        public List<Vector> FormList()
        {
            return _db.Vectors.Include(v => v.Alternative)
                .Include(v => v.Mark)
                .ThenInclude(m => m.Criterion)
                .ToList();
        }

        [Authorize]
        [HttpPost]
        public IActionResult ShowLinearConvolution(string alt, int maxMark)
        {
            string altName = alt.Split('|').First();
            int altVal = int.Parse(alt.Split('|').Last());

            _db.Results.Add(new Result
            {
                UserName = User.Identity.Name,
                IdAlt = _db.Alternatives.First(a => a.AName == altName).IdAlt,
                AWeight = altVal,
                Range = altVal == 0 ? 0 : (double)altVal / maxMark
            });

            _db.SaveChanges();

            return View("Result", new ResultViewModel
            {
                Results = _db.Results,
                Alternatives = _db.Alternatives
            });
        }

        public IActionResult Result()
        {
            return View("Result", new ResultViewModel
            {
                Results = _db.Results,
                Alternatives = _db.Alternatives
            });
        }

        public IActionResult RemoveResult(int idRes)
        {
            _db.Results.Remove(_db.Results.First(m => m.IdRes == idRes));
            _db.SaveChanges();

            return View("Result", new ResultViewModel
            {
                Results = _db.Results,
                Alternatives = _db.Alternatives
            });
        }

        // lab 3

        private static List<Alternative> Alternatives { get; set; } = new List<Alternative>();
        private static int ind = 0;

        [Authorize]
        public IActionResult Elimination()
        {
            if (Alternatives.Count == 0)
            {
                int val = 1;

                while (true)
                {
                    if (val * 2 <= _db.Alternatives.Count())
                        val *= 2;
                    else
                        break;
                }

                Alternatives = _db.Alternatives.Take(val).ToList();
            }

            var vects = FormList();

            while (ind <= Alternatives.Count())
            {
                int c = ind;
                int c1 = Alternatives.Count;

                if (ind + 2 > Alternatives.Count)
                    ind = 0;
                if (Alternatives.Count > 1)
                {
                    var v1 = vects.Where(v => v.Alternative.IdAlt == Alternatives[ind].IdAlt).ToList();
                    var v2 = vects.Where(v => v.Alternative.IdAlt == Alternatives[ind + 1].IdAlt).ToList();

                    return View(new EliminationViewModel
                    {
                        Alternative1 = Alternatives[ind],
                        Alternative2 = Alternatives[ind + 1],
                        Vectors1 = v1,
                        Vectors2 = v2
                    });
                }
                else
                {
                    _db.Results.Add(new Result
                    {
                        UserName = User.Identity.Name,
                        IdAlt = _db.Alternatives.First(a => a.AName == Alternatives.First().AName).IdAlt,
                        Range = 1,
                        AWeight = -1
                    });

                    _db.SaveChanges();

                    RestartElimination();

                    break;
                }
            }

            return RedirectToAction("Result");
        }

        [Authorize]
        [HttpPost]
        public IActionResult Elimination(int idAlt)
        {
            Alternatives.RemoveAll(a => a.IdAlt == idAlt);
            ind++;

            return RedirectToAction("Elimination");
        }

        [Authorize]
        [HttpPost]
        public IActionResult RestartElimination()
        {
            int val = 1;

            while (true)
            {
                if (val * 2 <= _db.Alternatives.Count())
                    val *= 2;
                else
                    break;
            }

            Alternatives = _db.Alternatives.Take(val).ToList();
            ind = 0;

            return RedirectToAction("Elimination");
        }

        [Authorize]
        public IActionResult GroupDecision()
        {
            if (_db.GroupDecisions.Count() >= _db.Users.Count() * _db.Alternatives.Count())
                foreach (var group in _db.GroupDecisions)
                    _db.GroupDecisions.Remove(group);
            _db.SaveChanges();

            if (_db.GroupDecisions.FirstOrDefault(g => g.UserName == User.Identity.Name) != null)
            {
                return View("GroupVoted");
            }

            return View(new GroupDecisionViewModel
            {
                Alternatives = _db.Alternatives
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult GroupDecision(string[] added)
        {
            for (int i = 0; i < added.Length; i++)
            {
                var dec = new GroupDecision
                {
                    UserName = User.Identity.Name,
                    IdAlt = int.Parse(added[i]),
                    Mark = added.Length - i
                };
                _db.GroupDecisions.Add(dec);
            }
            _db.SaveChanges();

            foreach (var user in _db.Users)
                if (_db.GroupDecisions.FirstOrDefault(g => g.UserName == user.UserName) == null)
                    return RedirectToAction("Index");

            CountGroupResult();

            return View("ShowSimpson", new ShowSimpsonViewModel
            {
                GroupDecisions = _db.GroupDecisions,
                Users = _db.Users,
                Alternatives = _db.Alternatives
            });
        }

        private void CountGroupResult()
        {
            var minResults = new Dictionary<int, int>();

            foreach (var alt in _db.Alternatives)
            {
                var curMarks = new List<int>();
                foreach (var curAlt in _db.Alternatives)
                {
                    if (curAlt != alt)
                    {
                        int mark = 0;
                        foreach (var user in _db.Users)
                        {
                            var alter = _db.GroupDecisions.First(g => g.UserName == user.UserName && g.IdAlt == alt.IdAlt);
                            var curAlter = _db.GroupDecisions.First(g => g.UserName == user.UserName && g.IdAlt != alt.IdAlt);
                            if (alter.Mark - curAlter.Mark > 0)
                                mark += alter.Mark - curAlter.Mark;
                        }
                        curMarks.Add(mark);
                    }
                }
                minResults.Add(alt.IdAlt, curMarks.Min());
            }

            int key = 0;
            int val = 0;
            foreach (var result in minResults)
            {
                if (result.Value > val)
                {
                    key = result.Key;
                    val = result.Value;
                }
            }

            _db.Results.Add(new Result
            {
                IdAlt = _db.Alternatives.First(a => a.IdAlt == key).IdAlt,
                Range = 1,
                AWeight = val,
                UserName = "Group"
            });

            _db.SaveChanges();
        }

        [Authorize]
        public IActionResult Absolute()
        {
            if (_db.AbsoluteDecisions.FirstOrDefault(d => d.UserName == User.Identity.Name) != null)
                return View("GroupVoted");

            return View(new AbsoluteViewModel
            {
                Alternatives = _db.Alternatives
            });
        }

        [Authorize]
        [HttpPost]
        public IActionResult Absolute(int idAlt)
        {
            _db.AbsoluteDecisions.Add(new AbsoluteDecision
            {
                UserName = User.Identity.Name,
                IdAlt = idAlt
            });
            _db.SaveChanges();

            if (_db.AbsoluteDecisions.Count() == _db.Users.Count())
            {
                int half = _db.Users.Count() / 2 + 1;

                foreach (var alt in _db.Alternatives)
                {
                    var n = alt.AName;
                    var t = _db.AbsoluteDecisions.Count(d => d.IdAlt == alt.IdAlt);
                    if (_db.AbsoluteDecisions.Count(d => d.IdAlt == alt.IdAlt) >= half)
                    {
                        _db.Results.Add(new Result
                        {
                            IdAlt = alt.IdAlt,
                            Range = 1,
                            AWeight = _db.AbsoluteDecisions.Count(d => d.IdAlt == alt.IdAlt),
                            UserName = "Absolute"
                        });

                        break;
                    }
                }

                foreach (var group in _db.AbsoluteDecisions)
                    _db.AbsoluteDecisions.Remove(group);
                _db.SaveChanges();

                return RedirectToAction("Result");
            }

            return RedirectToAction("Index");
        }
    }
}
