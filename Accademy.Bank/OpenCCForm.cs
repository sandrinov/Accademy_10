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
    public partial class OpenCCForm : Form
    {
        private string CurrentUser;
        public OpenCCForm(string username)
        {
            InitializeComponent();
            this.CurrentUser = username;
            this.label3.Text = CurrentUser;
            string numConto = Accademy.Helper.Helper.GetNumConto(20);
            this.label5.Text = numConto;
        }
        public OpenCCForm()
        {
            InitializeComponent();
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
            LoginForm loginform = (LoginForm)Tag;
            loginform.Close();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
