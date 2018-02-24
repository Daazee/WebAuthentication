using School.Abstractions.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using School.Model;
using School.Abstractions.Repositories;

namespace School.BLL
{
    public class StudentService : IStudentService
    {
        IStudentRepository _studentRepository;
        public StudentService(IStudentRepository studentRepository)
        {
            _studentRepository = studentRepository;
        }
        public async Task<Student> AddAsync(Student student)
        {
            var result = await _studentRepository.AddItemAsync(student);
            student.StudentId = result.StudentId;
            return student;
        }

        public async Task<IEnumerable<Student>> ListAsync()
        {
            return await _studentRepository.GetItemsAsync();
        }
    }
}
