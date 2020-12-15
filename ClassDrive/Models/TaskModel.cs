using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ClassDrive.Models
{
    public class TaskModel
    {
        [Key]
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string TaskDescription { get; set; }
        public string TaskDeadline { get; set; }
        public string TaskCourse { get; set; }
        public string TaskTeacher { get; set; }
    }
}
