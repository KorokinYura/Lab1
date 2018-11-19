using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models.ViewModels
{
    public class ShowSimpsonViewModel
    {
        public IEnumerable<GroupDecision> GroupDecisions { get; set; }
        public IEnumerable<LPR> Users { get; set; }
        public IEnumerable<Alternative> Alternatives { get; set; }
    }
}
