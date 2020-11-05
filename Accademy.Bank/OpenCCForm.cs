﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Accademy.Bank
{
    public partial class OpenCCForm : Form
    {
        public OpenCCForm()
        {
            InitializeComponent();
        }

        private void btn_manageCC_Click(object sender, EventArgs e)
        {
            ManageCCForm manageform = new ManageCCForm();
            manageform.Show();
            this.Close();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }
    }
}