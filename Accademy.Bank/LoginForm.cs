using System;
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
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (this.txt_username.Text == "A")
            {
                OpenCCForm openform = new OpenCCForm();
                openform.Tag = this;
                openform.Show();
                this.Hide();
            }
            else
            {
                ManageCCForm manageform = new ManageCCForm();
                manageform.Tag = this;
                manageform.Show();
                this.Hide();
            }
        }
    }
}
