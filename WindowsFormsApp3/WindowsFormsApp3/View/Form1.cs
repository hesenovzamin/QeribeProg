using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.Controller;
using WindowsFormsApp3.Model;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
       public   static  TeacherList Teacher = new TeacherList();
        public static int Gondermek = 0;
        public Form1()
        {
            InitializeComponent();
            
          //  StudentList student = new StudentList();
            ClassList classs = new ClassList();
            int[] a = new int[] { 1, 2 };
           // student.Add(new Student() {Id = 1,Name = "Zamin",Surname = "Hesenov", Username = "zamin5525",Age=18,Password = "student",Teacher_Id = 1,Class_Id=2});
            classs.Add(new Class(a) { Id = 1, Name = "tk56", });

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && password.Text == "admin")
            {
                Form();
                Gondermek = 0;
            }
            StudentList student = new StudentList();
            foreach (Student item in student)
            {
                if (item.Username == Username.Text && item.Password == password.Text)
                {
                    Form();
                    Gondermek = 1;
                }

            }
            int[] a = new int[] {1,2,3,4 };
            TeacherList Teacher = new TeacherList();
            Teacher.Add(new Teacher(a){ Id = 1, Name = "Zamin", Surname = "Hesenov", Username = "zamin5525", Age = 18, Password = "mellim", });
            foreach (Teacher item in Teacher)
            {

                if (item.Username == Username.Text && item.Password == password.Text)
                {
                    Form();
                    Gondermek = 2;
                }
            }
        }
        public void Form()
        {
            var AdminProfil = new AdminProfil();
            AdminProfil.Show();
            this.Hide();
           
        }
    }
}
