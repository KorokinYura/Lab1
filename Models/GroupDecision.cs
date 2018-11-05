using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class GroupDecision
    {
        [Key]
        public int IdDecision { get; set; }
        public string UserName { get; set; }
        public int IdAlt { get; set; }
        public int Mark { get; set; }
    }
}
