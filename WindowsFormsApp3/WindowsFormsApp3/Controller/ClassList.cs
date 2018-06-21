using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3.Controller
{
    class ClassList:IEnumerable
    {
        Class[] List = new Class[0];
        int Count = 0;
        public void Add(Class _class)
        {
            if (Count == List.Length)
            {
                Resize();
            }
            List[Count] = _class;
        }
        public void Resize()
        {
            Class[] resize = new Class[List.Length + 1];
            Array.Copy(List, resize, List.Length);
            List = resize;
        }
        public IEnumerator GetEnumerator()
        {
            return List.GetEnumerator();
        }
    }
}
