using OmphileStudyGroup.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OmphileStudyGroup.Controllers
{
    public class StudentController : Controller
    {
        // GET: Student
        public ActionResult Index()
        {
            List<Student> students = new List<Student>(); 

            students.Add(new Student { StudentNumber = "19229365",  Name = "Omphile", Surname = "Lekgetho", emailAddress = "omphilealekgetho@gmail.com"});
            students.Add(new Student { StudentNumber = "19229365", Name = "Omphile", Surname = "Lekgetho", emailAddress = "omphilealekgetho@gmail.com" });
            students.Add(new Student { StudentNumber = "19229365", Name = "Omphile", Surname = "Lekgetho", emailAddress = "omphilealekgetho@gmail.com" });
            students.Add(new Student { StudentNumber = "19229365", Name = "Omphile", Surname = "Lekgetho", emailAddress = "omphilealekgetho@gmail.com" });
            students.Add(new Student{ StudentNumber = "19229365", Name = "Omphile", Surname = "Lekgetho", emailAddress = "omphilealekgetho@gmail.com" });


            return View(students);
        }
    }
}