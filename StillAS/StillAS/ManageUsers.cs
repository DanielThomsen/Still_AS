﻿using System;
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
            btnAdd.Enabled = false;
        }

        private void dataUsers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.dataUsers.Rows[e.RowIndex];
                txtName.Text = row.Cells[0].Value.ToString();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string name = txtName.Text;

            if (name != "")
            {
                try
                {
                    CC.AddUser(name);

                    dataUsers.DataSource = CC.GetAllUsers();
                    txtName.Text = string.Empty;
                }
                catch (Exception)
                {

                    MessageBox.Show("Connection error");
                }
            }

            else
            {
                MessageBox.Show("Write a Sales Rep name to add it");
            }

            btnAdd.Enabled = false;
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            btnAdd.Enabled = true;
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Frontpage fp = new Frontpage();
            fp.Show();
            this.Visible = false;
        }

        private void ManageUsers_Load(object sender, EventArgs e)
        {

        }
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "Hjælpedokument.pdf";
            System.Diagnostics.Process.Start(@filename);
        }
    }
}
