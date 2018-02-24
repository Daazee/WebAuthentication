using School.Abstractions.Repositories;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School.DAL
{
    public class StudentRepository : BaseRepository<Student>, IStudentRepository
    {

    }
}
