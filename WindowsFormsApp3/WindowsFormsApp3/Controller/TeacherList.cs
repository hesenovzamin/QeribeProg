using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    class TeacherList
    {
        Teacher[] List = new Teacher[0];
        int Count = 0;
        public void Add(Teacher _teacher)
        {
            if (Count == List.Length)
            {
                Resize();
            }
            List[Count] = _teacher;
        }
        public void Resize()
        {
            Teacher[] resize = new Teacher[List.Length + 1];
            Array.Copy(List, resize, List.Length);
            List = resize;
        }
        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
