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
    public partial class WorkshopBookings : Form
    {
        ControllerClass CC = new ControllerClass();
        public WorkshopBookings()
        {
            InitializeComponent();
            try
            {
                List<string> bookingIDs = new List<string>();

                bookingIDs = CC.GetWaiting();

                foreach (string s in bookingIDs)
                {
                    lbBookings.Items.Add(s);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
         

            
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                string s = lbBookings.SelectedItem.ToString();
                int bookingIDSelected = Convert.ToInt32(lbBookings.SelectedItem);
               

                try
                {
                    CC.SetBookingID(bookingIDSelected);
                    ShowBooking SB = new ShowBooking(bookingIDSelected);
                    SB.Show();
                    this.Visible = false;
                }
                catch (Exception)
                {

                    MessageBox.Show("Connection error");
                }

               
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Booking not found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int Check = CC.UpdateNews(lbBookings.Items.Count);
                if (Check > lbBookings.Items.Count)
                {
                    Check = Check - lbBookings.Items.Count;
                    MessageBox.Show("There is " + Check + " new booking(s)");
                }
                lbBookings.Items.Clear();
                List<string> bookingIDs = new List<string>();
                bookingIDs = CC.GetWaiting();
                foreach (string s in bookingIDs)
                {
                    lbBookings.Items.Add(s);
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }

            
        }

        private void WorkshopBookings_Load(object sender, EventArgs e)
        {

        }
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start(@"C:\Users\Daniel\Source\Repos\Still_AS\StillAS\StillAS\bin\Debug\Hjælpedokument.pdf");
        }
    }
}
