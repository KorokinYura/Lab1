using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class ResultViewModel
    {
        public Result Result { get; set; }
        public IEnumerable<Result> Results { get; set; }
        public IEnumerable<Alternative> Alternatives { get; set; }
    }
}
