using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OpenEpsService.Models;
namespace OpenEpsService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            ViewBag.Message = "Welcome to my demo!";
            dynamic mymodel = new System.Dynamic.ExpandoObject();
            mymodel.Teachers = GetTeachers();
            mymodel.Students = GetStudents();
            return View(mymodel);

            ViewBag.Title = "Home Page";

           // return View();
        }
        public List<Teacher> GetTeachers()
        {
            List<Teacher> teachers = new List<Teacher>();
            teachers.Add(new Teacher { TeacherId = 1, Code = "TT", Name = "Tejas Trivedi" });
            teachers.Add(new Teacher { TeacherId = 2, Code = "JT", Name = "Jignesh Trivedi" });
            teachers.Add(new Teacher { TeacherId = 3, Code = "RT", Name = "Rakesh Trivedi" });
            return teachers;
        }

        public List<Student> GetStudents()
        {
            List<Student> students = new List<Student>();
            students.Add(new Student { StudentId = 1, Code = "L0001", Name = "Amit Gupta", EnrollmentNo = "201404150001" });
            students.Add(new Student { StudentId = 2, Code = "L0002", Name = "Chetan Gujjar", EnrollmentNo = "201404150002" });
            students.Add(new Student { StudentId = 3, Code = "L0003", Name = "Bhavin Patel", EnrollmentNo = "201404150003" });
            return students;
        }
    }
}
