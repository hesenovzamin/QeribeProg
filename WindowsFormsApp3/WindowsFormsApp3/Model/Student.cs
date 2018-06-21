using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class Student
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Username { get; set; }
        public int Age { get; set; }
        public int Password { get; set; }
        public int Teacher_Id { get; set; }
        public int Class_Id { get; set; }     
        public override string ToString()
        {
            return this.Id+ this.Name + " " + this.Surname + " " + this.Age + " " + this.Password + " " + this.Teacher_Id + " " + this.Class_Id;
        }
    }
}
