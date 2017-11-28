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
                ShowBooking SB = new ShowBooking(bookingIDSelected);
                SB.Show();

               

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not found");
            }
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            Customer_Information CI = new Customer_Information();
            CI.Show();
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            if (CC.AccessLevel() == 2)
            {
                btnRemove.Visible = false;
                btnEdit.Visible = false;
            }
            else if (CC.AccessLevel() == 3)
            {
                btnAddBooking.Visible = false;
                btnRemove.Visible = false;
                btnEdit.Visible = false;
            }
            else if (CC.AccessLevel() == 4)
            {
                btnAddBooking.Visible = false;
                btnRemove.Visible = false;
                btnEdit.Visible = false;
            }
        }
    }
}
