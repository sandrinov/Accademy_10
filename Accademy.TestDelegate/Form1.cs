﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.TestDelegate
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            MyClass mc = new MyClass(this.button1);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.label1.Text = this.textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedValueChanged(object sender, EventArgs e)
        {

        }
    }
}
