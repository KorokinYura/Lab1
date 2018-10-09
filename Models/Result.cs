using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Result
    {
        [Key]
        public int IdRes { get; set; }
        public int IdLPR { get; set; }
        public int IdAlt { get; set; }
        [Display(Name = "Ранг альтернативы")]
        public int Range { get; set; }
        [Display(Name = "Полезность альтернативы")]
        public int AWeight { get; set; }
        
        public Alternative Alternative { get; set; }
        public LPR LPR { get; set; }
    }
}
