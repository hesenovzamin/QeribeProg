using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    class StudentList
    {
        Student[] List = new Student[0];
        int Count = 0;
        public void Add(Student _student)
        {
            if (Count == List.Length)
            {
                Resize();
            }
            List[Count] = _student;
        }
        public void Resize()
        {
            Student[] resize = new Student[List.Length + 1];
            Array.Copy(List, resize, List.Length);
            List = resize;
        }
        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
