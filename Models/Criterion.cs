using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Criterion
    {
        [Key]
        public int IdCrit { get; set; }
        [Required]
        public string CName { get; set; }
        [Required]
        public int CRange { get; set; }
        [Required]
        public int CWeight { get; set; }
        [Required]
        public string CType { get; set; }
        [Required]
        public string OptimType { get; set; }
        public string EdIzmer { get; set; }
        [Required]
        public string ScaleType { get; set; }
    }
}
