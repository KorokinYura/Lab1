using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Mark
    {
        [Key]
        public int IdMark { get; set; }
        public int IdCrit { get; set; }
        [Required]
        public string MName { get; set; }
        public int MRange { get; set; }
        public int NumMark { get; set; }
        public int NormMark { get; set; }

        public Criterion Criterion { get; set; }
    }
}
