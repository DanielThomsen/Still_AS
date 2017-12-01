using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace StillAS
{
    public partial class LoginScreen : Form
    {
        ControllerClass CC = new ControllerClass();
        public LoginScreen()
        {
            InitializeComponent();
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            int Check = CC.Validation(tbUsername.Text, tbPassword.Text);
            if (Check == 0)
            {
                this.Visible = false;
                Frontpage fp = new Frontpage();
                fp.Show();
            }   
            else
            {
                MessageBox.Show("Wrong Username or Password. Please try again");
            }
        }
    }
}
