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

        private void dataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                // En collection af rows, hvor Cell Click er RowIndex
                DataGridViewRow row = this.dataUsers.Rows[e.RowIndex];
                //populate the textbox from specific value of the coordinates of column and row.
                txtName.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;
            CC.AddUser(name);
        }
    }
}
