using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelloWorld.Models;
namespace HelloWorld.Controllers
{
    public class StudentController : Controller
    {
        static IList<Student> studentList = new List<Student>{
                                    new Student() { StudentId = 1, StudentName = "John", Age = 18 } ,
                                    new Student() { StudentId = 2, StudentName = "Steve",  Age = 21 } ,
                                    new Student() { StudentId = 3, StudentName = "Bill",  Age = 25 } ,
                                    new Student() { StudentId = 4, StudentName = "Ram" , Age = 20 } ,
                                    new Student() { StudentId = 5, StudentName = "Ron" , Age = 31 } ,
                                    new Student() { StudentId = 6, StudentName = "Chris" , Age = 17 } ,
                                    new Student() { StudentId = 7, StudentName = "Rob" , Age = 19 }
                                };
        static int index;
        // GET: Student

        public ActionResult Index()
        {
            // Get the students from the database in the real application

            return View(studentList);
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            var std = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            index = id;
            return View(std);
        }

        [HttpPost]
        public ActionResult Edit(Student std)
        {
            var student = studentList.Where(s => s.StudentId == index).FirstOrDefault();
            student.Age = std.Age;
            student.StudentName = std.StudentName;
            /* localStd.Age = std.Age; */
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int id)
        {
            var student = studentList.Where(s => s.StudentId == id).FirstOrDefault();
            studentList.Remove(student);

            return RedirectToAction("Index");
        }

        public ContentResult OutofAction()
        {
            return Content("HelloWorld, You accessed out of actions in StudentController");
        }
    }
}