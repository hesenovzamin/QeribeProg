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

namespace WindowsFormsApp3.View
{
    public partial class Add : Form
    {
       public static int countmellim = 0;
        public static int countsinif = 0;

        public static int count = 0;

        public Add()
        {
            InitializeComponent();
        }

        private void Add_Load(object sender, EventArgs e)
        {
            if (AdminProfil.Addtype == 0)
            {
                MessageBox.Show("Telebe yaradassiz");
                foreach (Teacher item in TeacherController.List)
                {
                    Teacher.Items.Add(item.Id);
                }
            }
            //foreach (Teacher item in mellim)
            //{
            //    Teacher.Items.Add(item.Id);
            //    countmellim++;
            //    countsinif++;

            //}
            if (AdminProfil.Addtype ==1)
            {
                MessageBox.Show("Siz Mellim YaRADASSUZ");
                label6.Text = "Student";
            }
        }
             public int[] idmellim = new int[countmellim];
             public int[] idsinif = new int[countsinif];

        private void button1_Click(object sender, EventArgs e)
        {
            if (AdminProfil.Addtype == 0)
            {
                if (countmellim == idmellim.Length)
                {
                    int[] resize = new int[idmellim.Length + 1];
                    Array.Copy(idmellim, resize, idmellim.Length);
                    idmellim = resize;
                }
                idmellim[count] = Convert.ToInt32(Teacher.SelectedItem.ToString());
            }
            

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (AdminProfil.Addtype == 0)
            {
                var Add = new StudentController();
                var Telebe = new Student();
                Telebe.Name = Name.Text;
                Telebe.Surname = Surname.Text;
                Telebe.Username = Username.Text;
                Telebe.Age = Age.Text;
                Telebe.Teacher_Id = idmellim;
                Telebe.Password = Password.Text;
                Telebe.Class_Id = Convert.ToInt32(Class.SelectedItem.ToString());
                Add.Add(Telebe);
            }
            if (AdminProfil.Addtype == 1)
            {
                var Add = new TeacherController();
                var mellim = new Teacher();
                mellim.Name = Name.Text;
                mellim.Surname = Surname.Text;
                mellim.Username = Username.Text;
                mellim.Age = Age.Text;
                mellim.Student_id = idmellim;
                mellim.Password = Password.Text;
                mellim.Class_id = idmellim;
                Add.Add(mellim);
            }

        }
    }
}
