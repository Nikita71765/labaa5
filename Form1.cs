﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            if (radioButton1.Checked)

                if (radioButton2.Checked) ;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            if (radioButton2.Checked)
                form3.Show();
            else return;



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            {

                Form2 form2 = new Form2();
                if (radioButton1.Checked)
                    form2.Show();
                else return;

            }
        }
    }
}

