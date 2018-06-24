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
        public static int Gondermek = 0;
        public Form1()
        {
            InitializeComponent();
            
            int[] a = new int[] { 1, 2 };
      
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && password.Text == "admin")
            {
                Form();
                Gondermek = 0;
            }
            foreach (Student item in StudentController.List)
            {
                if (item.Username == Username.Text && item.Password == password.Text)
                {
                    Form();
                    Gondermek = 1;
                }

            }
            foreach (Teacher item in TeacherController.List)
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
