﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public static int Gondermek = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (Username.Text == "admin" && password.Text == "admin")
            {
                Gondermek = 0;
            }
            else if(Username.Text == "admin" && password.Text == "admin")
            {

            }
        }
    }
}
