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
    public partial class CarrierForm : Form
    {
        ControllerClass CC = new ControllerClass();
        public CarrierForm()
        {
            InitializeComponent();
        }

        private void btnShowBookings_Click(object sender, EventArgs e)
        {
            libBookingID.Items.Clear();
            DateTime date = dtpStartDate.Value.Date;
            //string datestring = date.ToString().Substring(0, 10);

            List<int> bookingIDList = CC.GetBookingsForCarrier(date);

            foreach (int i in bookingIDList)
            {
                libBookingID.Items.Add(i);
            }
        }

        private void libBookingID_SelectedIndexChanged(object sender, EventArgs e)
        {
            libDemoNumber.Items.Clear();
            List<string> demonumbers = new List<string>();
            int bookingIdSelected = Convert.ToInt32(libBookingID.SelectedItem.ToString());

            demonumbers = CC.GetDemoNumbersByBooking(bookingIdSelected);

            foreach (string s in demonumbers)
            {
                libDemoNumber.Items.Add(s);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            //AddMachine am = new AddMachine(demonumber);
            //am.Show();
            try
            {
                string s = libBookingID.SelectedItem.ToString();
                int bookingID = Convert.ToInt32(s);
                if (bookingID != 0)
                {
                    try
                    {
                        string demonumber = libDemoNumber.SelectedItem.ToString();
                        if (demonumber != "" || demonumber != "-1")
                        {
                            AddMachine am = new AddMachine(demonumber);
                            am.Show();
                        }

                        else
                        {
                            ShowBooking sb = new ShowBooking(bookingID);
                            sb.Show();
                        }

                        // Åben show machine-form
                       
                    }
                    catch (Exception)
                    {
                        // Åben show booking-form
                        ShowBooking sb = new ShowBooking(bookingID);
                        sb.Show();

                    }
                }

                else
                {
                    MessageBox.Show("Booking not selected");
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Booking not selected");
            }
            
            
        }
    }
}
