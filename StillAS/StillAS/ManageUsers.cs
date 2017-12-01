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
    public partial class ManageUsers : Form
    {
        ControllerClass CC = new ControllerClass();
        public ManageUsers()
        {
            InitializeComponent();
            dataUsers.DataSource = CC.GetAllUsers();
        }

        private void dataUsers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // En collection af rows, hvor Cell Click er RowIndex
                DataGridViewRow row = this.dataUsers.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtUsername.Text = row.Cells[0].Value.ToString();
                txtName.Text = row.Cells[1].Value.ToString();
                txtPassword.Text = row.Cells[2].Value.ToString();
                coboAccessLevel.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text;
            string name = txtName.Text;
            string password = txtPassword.Text;
            string accessLevel = coboAccessLevel.Text;

            CC.AddUser(username, name, password, accessLevel);

            dataUsers.DataSource = CC.GetAllUsers();

            List<TextBox> Users = new List<TextBox>() { txtUsername, txtName, txtPassword };
            foreach (TextBox t in Users)
            {
                t.Clear();
            }
            coboAccessLevel.Text = string.Empty;
        }
    }
}
