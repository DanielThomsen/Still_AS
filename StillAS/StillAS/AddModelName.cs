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
    public partial class AddModelName : Form
    {
        ControllerClass CC = new ControllerClass();
        public AddModelName()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            CC.AddModelName(txtModelname.Text);
            this.Close();
        }
    }
}
