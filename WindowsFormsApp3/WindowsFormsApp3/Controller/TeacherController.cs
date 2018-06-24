using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    class TeacherController
    {
        public static TeacherList List = new TeacherList();

        public void Add(Teacher _T)
        {
            List.Add(_T);
        }
    }
}
