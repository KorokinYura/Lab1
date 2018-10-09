using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Alternative
    {
        [Key]
        public int IdAlt { get; set; }
        [Required]
        [Display(Name = "Наименование альтернативы")]
        public string AName { get; set; }
    }
}
