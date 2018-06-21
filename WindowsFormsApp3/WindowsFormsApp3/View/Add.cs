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
         TeacherList mellim = new TeacherList();

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
            }
            TeacherList mellim = new TeacherList();
            foreach (Teacher item in mellim)
            {
                Teacher.Items.Add(item.Id);
                countmellim++;
                countsinif++;
                
            }
        }
             public int[] idmellim = new int[countmellim];
             public int[] idsinif = new int[countsinif];

        private void button1_Click(object sender, EventArgs e)
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
}
