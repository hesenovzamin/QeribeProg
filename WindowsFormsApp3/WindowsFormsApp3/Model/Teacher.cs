using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class Teacher
    {
        int count = 0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Username { get; set; }
        public int Age { get; set; }
        public string Password { get; set; }
        public int[] Student_id = new int[0];
        public int[] Class_id = new int[0];
        public Teacher(int [] _a)
        {
            Student_id = _a;
            Class_id = _a;
        }
    }
}
