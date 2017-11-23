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
                int bookingIDSelected = 2; //Convert.ToInt32(libBookingID.SelectedItem);
                //Show_Machine SM = new Show_Machine(bookingIDSelected);
                //SM.Show();

                // Vis alle kundeoplysninger:
                List<string> customers = CC.GetCustomer(bookingIDSelected);
                string allCustomerInfoString = "";

                foreach (string s in customers)
                {
                    allCustomerInfoString = allCustomerInfoString + s + ", ";
                }

                MessageBox.Show("Booking ID " + bookingIDSelected + ", kundeoplysninger:" + allCustomerInfoString);

                // Vis alle bookingoplysninger:
                List<string> booking = CC.GetCustomer(bookingIDSelected);
                string allBookingInfoString = "";

                foreach (string s in booking)
                {
                    allBookingInfoString = allBookingInfoString + s + ", ";
                }

                MessageBox.Show("All booking info: " + allBookingInfoString);

                // Vis alle maskiner på booking:
                List<string> machines = CC.GetMachines(bookingIDSelected);
                string allMachinesInBooking = "";

                foreach (string s in machines)
                {
                    allMachinesInBooking = allMachinesInBooking + s + ", ";
                }

                MessageBox.Show("All machines in booking: "+allMachinesInBooking);

                //Vis alle konfigurationer på bookings maskiner:
                
                // Liste af konfigurationer for hver maskine skal hentes og gøres tilgængelig her
                // så de kan indsættes i listboxen der opdateres alt efter hvilken maskine der vælges

                MessageBox.Show("Form skal åbnes her. Så vises alt om bookingen.");

            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not removed");
            }
        }
    }
}
