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
        public string assignments { get; set; }
        public string group_projects { get; set; }

        public string quizzes { get; set; }

        public string exams { get; set; }

        public string intex { get; set; }

    }
}