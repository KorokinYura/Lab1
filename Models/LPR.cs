using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class LPR
    {
        [Key]
        public int IdLPR { get; set; }
        public string LName { get; set; }
        public int LRange { get; set; }
    }
}
