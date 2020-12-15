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
    public class ContentModel
    {
        [Key]
        public int ContentID { get; set; }
        [ForeignKey("CourseModel")]
        public int CourseID { get; set; }
        public string ContentName { get; set; }
        [DisplayName("Content Name")]
        public string ContentDescription { get; set; }
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ContentFile { get; set; }
    }
}
