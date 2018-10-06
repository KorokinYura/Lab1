using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Lab1.Models;
using Lab1.Data;
using Lab1.Models.ViewModels;

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
    }
}
