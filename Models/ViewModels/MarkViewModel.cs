using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class MarkViewModel
    {
        public Mark Mark { get; set; }
        public Criterion Criterion { get; set; }
        public IEnumerable<Mark> Marks { get; set; }
        public IEnumerable<Criterion> Criterions { get; set; }
    }
}
