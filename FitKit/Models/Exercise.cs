using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace FitKit.Models
{
    public class Exercise
    {
        [Required]
        public string Name { get; set; }
        [Required]
        public int NumSets { get; set; }
        [Required]
        public int NumReps { get; set; }
        [Required]
        public int Weight { get; set; }

    }
}
