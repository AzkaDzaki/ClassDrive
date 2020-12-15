using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace ClassDrive.Models
{
    public class SubmitModel
    {
        [Key]
        public int SubmitID { get; set; }
        [ForeignKey("TaskModel")]
        public int TaskID { get; set; }
        public string SubmitName { get; set; }
        public string SubmitDescription { get; set; }
        public string SubmitTime { get; set; }
        public string SubmitScore { get; set; }
        [NotMapped]
        public IFormFile ContentFile { get; set; }
    }
}
