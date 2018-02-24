using School.Abstractions.Services;
using School.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace School.Web.Controllers
{
    public class StudentController : Controller
    {
        IStudentService _studentService;
        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
       
        [Authorize(Roles ="User")]
        [HttpGet]
        public ActionResult Insert()
        {
            return View();
        }

       [HttpPost]
        public async  Task<ActionResult> Insert(Student student)
        {
            var result = await _studentService.AddAsync(student);
            return View();
        }

        [HttpGet]
        public async Task<ActionResult> Index()
        {
            return View(await _studentService.ListAsync());
        }
    }
}