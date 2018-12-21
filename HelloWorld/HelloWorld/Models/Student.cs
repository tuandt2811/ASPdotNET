using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelloWorld.Models
{
    public class Student
    {
        public int StudentId { get; set; }
        public string StudentName { get; set; }
        public int Age { get; set; }
    }

    public class EditFrom
    {
        public int FormId { get; set; }
        public Student StudentForm { get; set; }
    }
}