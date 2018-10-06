using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class AlternativeViewModel
    {
        public Alternative Alternative { get; set; }
        public Criterion Criterion { get; set; }
        public Mark Mark { get; set; }
        public Vector Vector { get; set; }
        public IEnumerable<Alternative> Alternatives { get; set; }
        public IEnumerable<Criterion> Criterions { get; set; }
        public IEnumerable<Mark> Marks { get; set; }
        public IEnumerable<Vector> Vectors { get; set; }
    }
}
