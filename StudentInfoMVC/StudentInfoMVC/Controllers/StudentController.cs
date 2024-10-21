using Microsoft.AspNetCore.Mvc;
using StudentInfoMVC.Data;
using StudentInfoMVC.Models;
using System.Collections.Generic;

namespace StudentInfoMVC.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult Index()
        {
            List<Student> students= DataStore.Students;
            return View(students);
        }
    }
}
