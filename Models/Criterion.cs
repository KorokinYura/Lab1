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
        [Display(Name = "Наименование критерия")]
        public string CName { get; set; }
        [Required]
        [Display(Name = "Ранг критерия")]
        public int CRange { get; set; }
        [Required]
        [Display(Name = "Важность критерия")]
        public int CWeight { get; set; }
        [Required]
        [Display(Name = "Тип критерия")]
        public string CType { get; set; }
        [Required]
        [Display(Name = "Тип оптимальности критерия")]
        public string OptimType { get; set; }
        [Display(Name = "Единица измерения")]
        public string EdIzmer { get; set; }
        [Required]
        [Display(Name = "Тип шкалы")]
        public string ScaleType { get; set; }
    }
}
