using HolmesglenStudentManagementSystem.DataAccessLayer;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HolmesglenStudentManagementSystem.Models.EntityFramework
{
    // build connection between application and database
    public class APPDBContext : DbContext
    {
        public DbSet<Student_EF> Student { get; set; }
        public DbSet<Subject_EF> Subject { get; set; }
        public DbSet<Enrollment_EF> Enrollment { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // change the connection string below as needed
            optionsBuilder.UseSqlite(@"Data Source=E:\Programming\ICTPRG432 Develop data-driven applications\AT2\data-driven-at2-202220\HolmesglenStudentManagementSystem.db");
        }
    }
}
