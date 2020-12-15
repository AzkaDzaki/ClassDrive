using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ClassDrive.Models;

namespace ClassDrive.Models
{
    public class DriveDbContext:DbContext
    {
        public DriveDbContext(DbContextOptions<DriveDbContext> options) : base(options)
        {

        }

        public DbSet<ContentModel> ContentModel { get; set; }
        public DbSet<CourseModel> CourseModel { get; set; }
        public DbSet<ClassDrive.Models.AccountModel> AccountModel { get; set; }
        public DbSet<TaskModel> TaskModel { get; set; }
        public DbSet<SubmitModel> SubmitModel { get; set; }
    }
}
