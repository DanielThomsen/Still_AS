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
    public partial class BookingsOverview : Form
    {
        ControllerClass CC = new ControllerClass();
        public BookingsOverview()
        {
            InitializeComponent();
        }

        private void btnShowAllBookings_Click(object sender, EventArgs e)
        {
            //DataSet ds = new DataSet();

            //List<List<string>> bookings = CC.GetAllBookings();

            //foreach (List<string> data in bookings)
            //{
            //gvBookings.DataSource = ds.Tables
            //}





            //DataSet ds = CC.GetAllBookings();

            //int i = 0;
            //while (i < ds.Tables.Count)
            //{
            //    gvBookings.DataSource = ds.Tables[0];
            //    i++;
            //}



            gvBookings.DataSource = CC.GetAllBookings();

        

           
            

            //gvBookings.Show();

        }

        private void dtpDate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnShowBookingsByDate_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dtpDate.Value.Date.ToString("yyyy-MM-dd h:mm tt"));
            gvBookings.DataSource = CC.GetBookingsByDate(dtpDate.Value.Date);
        }

        private void gvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookingsOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stillasDataSet.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.stillasDataSet.Booking);

        }
    }
}
