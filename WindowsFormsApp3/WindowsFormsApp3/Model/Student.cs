using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Controller;

namespace WindowsFormsApp3.Model
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public string Age { get; set; }
        public string Password { get; set; }
        public int Class_Id { get; set; }
        public int[] Teacher_Id = new int[0];
    }
}
