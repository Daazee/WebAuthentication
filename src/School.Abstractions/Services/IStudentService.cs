using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.Abstractions.Services
{
   public interface IStudentService
    {
        Task<Student> AddAsync(Student student);
        Task<IEnumerable<Student>> ListAsync();
    }
}
