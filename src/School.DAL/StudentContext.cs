using School.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL
{
   public class StudentContext : DbContext
    {
        public StudentContext()
             : base("DefaultConnection")
        {
        }
        public DbSet<Student> Students { get; set; }
        public DbSet<Course> Course { get; set; }
    }
}
