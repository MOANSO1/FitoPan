using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FitoPan
{
    public partial class LoginMenu : Form
    {
        public LoginMenu()
        {
            InitializeComponent();
        }

        private void ImageExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rpta_password.Text == "" || rpta_username.Text == "") return;
            FitoPan.getInstance().getEmpleadoTable().findUserPassword(rpta_username.Text, rpta_password.Text);
        }
    }
}
