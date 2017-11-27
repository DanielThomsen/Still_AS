using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StillAS
{
    public partial class Frontpage : Form
    {
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
    }
}
