using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rumble
{
    public partial class AdminLogin : Form
    {
        public AdminLogin()
        {
            InitializeComponent();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            if(txbUsername.Text == "admin" && txbPassword.Text == "tsbj")
            {
                AdminPanel adminPanel = new AdminPanel();
                adminPanel.ShowDialog();
            }
            else
            {
                lblError.Visible = true;
                errorTimer.Start();
            }
        }

        private void errorTimeout(object sender, EventArgs e)
        {
            lblError.Visible = false;
            errorTimer.Stop();
        }
    }
}
