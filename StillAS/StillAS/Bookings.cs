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
                foreach (string s in customers)
                {
                    libCustomerName.Items.Add(s);
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
                    DialogResult dRes = MessageBox.Show("Are you sure you want to delete Booking ID " + libBookingID.SelectedItem + "?", "Attention!", MessageBoxButtons.YesNo);
                    if (dRes == DialogResult.Yes)
                    {
                        int bookingIDSelected = Convert.ToInt32(libBookingID.SelectedItem);
                        CC.RemoveBooking(bookingIDSelected);
                        MessageBox.Show("Booking removed: Booking ID:" + bookingIDSelected);
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
            //catch(Exception)
            //{
            //    MessageBox.Show("Connection error");
            //}
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                if (CC.CheckConnection() == true)
                {
                    int bookingIDSelected = Convert.ToInt32(libBookingID.SelectedItem);
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
            //catch(Exception)
            //{
            //    MessageBox.Show("Connection error");
            //}
        }

        private void libCustomerName_Click(object sender, EventArgs e)
        {
            //libBookingConfigurations.Items.Clear();

            //List<string> configurations = new List<string>();
            //string machine = libBookingMachines.SelectedItem.ToString();

            //configurations = CC.GetConfigurations(machine);

            //foreach (string s in configurations)
            //{
            //    libBookingConfigurations.Items.Add(s);
            //}

            try
            {
                libCity.Items.Clear();

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
                        libCity.Items.Add(s); // adresse, eller by?
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
                string adress = libCity.SelectedItem.ToString();

                bookingIDs = CC.GetBookingID(adress);

                foreach (string s in bookingIDs)
                {
                    libBookingID.Items.Add(s);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
                //MessageBox.Show("Error: There is no bookings linked to this customer");
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
                libBookingID.Items.Clear();
                libCity.Items.Clear();
                libCustomerName.Items.Clear();
                List<string> customers = CC.GetAllCustomers();
                foreach (string s in customers)
                {
                    libCustomerName.Items.Add(s);
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
    }
}
