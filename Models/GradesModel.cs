using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Mike01.Models
{
    public class GradesModel
    {
        [Required]
        [Range(0, 100, ErrorMessage = "Must be between 0 and 100")]
        public double assignments { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Must be between 0 and 100")]
        public double group_projects { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Must be between 0 and 100")]
        public double quizzes { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Must be between 0 and 100")]
        public double exams { get; set; }
        [Required]
        [Range(0, 100, ErrorMessage = "Must be between 0 and 100")]
        public double intex { get; set; }

    }
}