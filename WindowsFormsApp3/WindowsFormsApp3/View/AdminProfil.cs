using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp3.View;

namespace WindowsFormsApp3
{
    public partial class AdminProfil : Form
    {
        public static int Addtype = 0;
        public AdminProfil()
        {
            InitializeComponent();
        }

        private void ADDSTUDENT_Click(object sender, EventArgs e)
        {
            Addtype = 0;
            var add = new Add();
            var AdminProfil = new AdminProfil();
            add.Show();
           
            AdminProfil.Hide();
        }
    }
}
