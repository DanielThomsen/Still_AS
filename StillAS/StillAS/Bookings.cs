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
    public partial class Bookings : Form
    {
        ControllerClass CC = new ControllerClass();
        public Bookings()
        {
            InitializeComponent();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingIDSelected = Convert.ToInt32(libBookingID.SelectedItem);
                CC.RemoveBooking(bookingIDSelected);
                MessageBox.Show("Machine removed: Booking ID:" + bookingIDSelected);
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not removed");
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingIDSelected = Convert.ToInt32(libBookingID.SelectedItem);
                //Show_Machine SM = new Show_Machine(bookingIDSelected);
                //SM.Show();
                MessageBox.Show("Form skal åbnes her. Så vises alt om bookingen.");

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not removed");
            }
        }
    }
}
