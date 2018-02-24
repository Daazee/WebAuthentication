using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Model
{
    public class StudentCourse
    {

        [ForeignKey("StudentId")]
        public int StudentId {get; set;}
        [ForeignKey("CourseId")]
        public string CourseId { get; set; }
        
    }
}
