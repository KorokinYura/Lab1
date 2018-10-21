using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class LinearConvolutionViewModel
    {
        public IEnumerable<Vector> Vectors { get; set; }
        public Dictionary<string, int> AltValues { get; set; }
        public Criterion Criterion { get; set; }
        public Mark Mark { get; set; }
    }
}
