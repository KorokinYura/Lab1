using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Lab1.Models
{
    public class Vector
    {
        [Key]
        public int IdVect { get; set; }
        public int IdAlt { get; set; }
        public int IdMark { get; set; }
        
        public Alternative Alternative { get; set; }
        public Mark Mark { get; set; }
    }
}
