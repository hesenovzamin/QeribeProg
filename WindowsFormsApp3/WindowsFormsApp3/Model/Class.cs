using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp3.Model
{
    class Class
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int[] Student_id = new int[0];
        public int[] Teacher_id = new int[0];
        public Class(int [] _a)
        {
            Student_id = _a;
            Teacher_id = _a;
        }
    }
}
