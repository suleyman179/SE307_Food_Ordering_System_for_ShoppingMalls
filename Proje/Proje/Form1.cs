﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        
        private void btnBurger_Click(object sender, EventArgs e)
        {
            burgerkingUC1.BringToFront();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            kfc1.BringToFront();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            mcDonalds1.BringToFront();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            dominos1.BringToFront();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            subway1.BringToFront();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            homepage1.BringToFront();
        }
    }
}
