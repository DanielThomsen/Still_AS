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

            try
            {                
                List<string> customers = CC.GetAllCustomers();
                string count = "";
                foreach (string s in customers)
                {
                    if (s == count)
                    {

                    }
                    else
                    {
                        libCustomerName.Items.Add(s);
                        count = s;
                    }
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }



        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                if (CC.CheckConnection() == false)
                {
                    throw new Exception();
                }
                

                try
                {
                    DialogResult dRes = MessageBox.Show("Are you sure you want to delete Booking ID " + CC.BookingIntSpawner(libBookingID.SelectedItem.ToString()) + "?", "Attention!", MessageBoxButtons.YesNo);
                    if (dRes == DialogResult.Yes)
                    {
                        string BookingID = CC.BookingIntSpawner(libBookingID.SelectedItem.ToString());
                        int bookingIDSelected = Convert.ToInt32(BookingID);
                        CC.RemoveBooking(bookingIDSelected);
                        MessageBox.Show("Booking removed: Booking ID:" + bookingIDSelected);
                        libBookingID.Items.Clear();
                    }
                    else
                    {

                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Error: Booking not removed");
                }

            }

            catch (Exception
            )
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (CC.CheckConnection() == true)
                {
                    string lib = CC.BookingIntSpawner(libBookingID.SelectedItem.ToString());
                    int bookingIDSelected = Convert.ToInt32(lib);
                    ShowBooking SB = new ShowBooking(bookingIDSelected);
                    SB.Show();
                    this.Visible = false;
                }

                else
                {
                    MessageBox.Show("Connection error");
                }

            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Error: Booking not found");
            }
        }

        private void libCustomerName_Click(object sender, EventArgs e)
        {
            try
            {
                libCity.Items.Clear();
                libBookingID.Items.Clear();

                List<string> addresses = new List<string>();
                string customer = libCustomerName.SelectedItem.ToString();

                addresses = CC.GetAdresses(customer);
                string city = "";
                foreach (string s in addresses)
                {
                    if (s == city)
                    {

                    }
                    else
                    {
                        libCity.Items.Add(s);
                        city = s;
                    }
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
                
            }
            
        }

        private void btnAddBooking_Click(object sender, EventArgs e)
        {
            try
            {
                if (CC.CheckConnection() == true)
                {
                    Demo_Maskiner DM = new Demo_Maskiner();
                    DM.Show();
                }

                else
                {
                    MessageBox.Show("Connection error");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
           
        }

        private void libCity_Click(object sender, EventArgs e)
        {
            try
            {
                libBookingID.Items.Clear();

                List<string> bookingIDs = new List<string>();
                List<string> status = new List<string>();
                string adress = libCity.SelectedItem.ToString();

                bookingIDs = CC.GetBookingID(adress);
                status = CC.GetStatus(adress);
                int i = 0;
                foreach (string s in bookingIDs)
                {
                    libBookingID.Items.Add(s + ", " + status[i]);
                    i++;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void Bookings_Load(object sender, EventArgs e)
        {
            if (CC.AccessLevel() == 2)
            {
                btnRemove.Visible = false;
            }
            else if (CC.AccessLevel() == 3)
            {
                btnAddBooking.Visible = false;
                btnRemove.Visible = false;
            }
            else if (CC.AccessLevel() == 4)
            {
                btnAddBooking.Visible = false;
                btnRemove.Visible = false;
            }
        }

        private void btnShowBookingsOverview_Click(object sender, EventArgs e)
        {
            try
            {
                if (CC.CheckConnection() == true)
                {
                    BookingsOverview bo = new BookingsOverview();
                    bo.Show();
                }

                else
                {
                    MessageBox.Show("Connection error");
                }
                
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
            
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void libCustomerName_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                libCustomerName.Items.Clear();
                libBookingID.Items.Clear();
                libCity.Items.Clear();
                List<string> customers = CC.GetAllCustomers();
                string count = "";
                foreach (string s in customers)
                {
                    if (s == count)
                    {

                    }
                    else
                    {
                        libCustomerName.Items.Add(s);
                        count = s;
                    }
                }
                libCity.Items.Clear();
                libBookingID.Items.Clear();
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Frontpage fp = new Frontpage();
            fp.Show();
            this.Visible = false;
        }

        private void libBookingID_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void viewHelpToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            string filename = "Hjælpedokument.pdf";
            System.Diagnostics.Process.Start(@filename); // ÅBNER MANUALEN
        }
    }
}
