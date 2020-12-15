using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassDrive.Models
{
    public class CourseModel
    {
        [Key]
        public int CourseID { get; set; }
        public string CourseName { get; set; }
        public string CourseDescription { get; set; }
        public string CourseSchedule { get; set; }
        public string CourseTeacher { get; set; }
    }
}
