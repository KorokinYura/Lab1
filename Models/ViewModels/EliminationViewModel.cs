using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class EliminationViewModel
    {
        public Alternative Alternative1 { get; set; }
        public Alternative Alternative2 { get; set; }
        
        public List<Vector> Vectors1 { get; set; }
        public List<Vector> Vectors2 { get; set; }

        public Mark Mark { get; set; }
        public Criterion Criterion { get; set; }
    }
}
