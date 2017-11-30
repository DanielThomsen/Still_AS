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
    public partial class Frontpage : Form
    {
        ControllerClass CC = new ControllerClass();
        public Frontpage()
        {
            InitializeComponent();
        }

        private void btnMachines_Click(object sender, EventArgs e)
        {
            Machines M = new Machines();
            M.Show();
        }

        private void btnBookings_Click(object sender, EventArgs e)
        {
            Bookings B = new Bookings();
            B.Show();
        }

        private void Frontpage_Load(object sender, EventArgs e)
        {
            if (CC.AccessLevel() == 2)
            {
                btnManageUsers.Visible = false;
            }
            else if (CC.AccessLevel() == 3)
            {
                btnMachines.Visible = false;
                btnManageUsers.Visible = false;
            }
            else if (CC.AccessLevel() == 4)
            {
                btnMachines.Visible = false;
                btnManageUsers.Visible = false;
            }
        }

        private void btnUr_Click(object sender, EventArgs e)
        {
            Clocks c = new Clocks();
            c.Show();
        }
    }
}
