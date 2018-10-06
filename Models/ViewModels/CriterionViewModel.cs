using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class CriterionViewModel
    {
        public Criterion Criterion { get; set; }
        public IEnumerable<Criterion> Criterions { get; set; }
    }
}
