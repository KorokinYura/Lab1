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
        [Display(Name = "Наименование оценки")]
        public string MName { get; set; }
        [Display(Name = "Ранг оценки")]
        public int MRange { get; set; }
        [Display(Name = "Колличественный эквивалент оценки")]
        public int NumMark { get; set; }
        [Display(Name = "Нормированная оценка")]
        public int NormMark { get; set; }

        public Criterion Criterion { get; set; }
    }
}
