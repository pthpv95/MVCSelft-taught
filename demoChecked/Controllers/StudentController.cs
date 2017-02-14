using demoChecked.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace demoChecked.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Student(StudentViewModel model)
        {
            string department = model.Departments.ToString();
            TempData["Message"] = department;
            return View(model);
        }
    }
}