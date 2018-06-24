using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    class StudentController
    {
        public static StudentList List = new StudentList();

        public void Add(Student _std)
        {
            List.Add(_std);
        }
    }
}
