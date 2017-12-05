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

        private void btnShowCalendar_Click(object sender, EventArgs e)
        {
            DateTime startdate = dtpStartDate.Value;
            DateTime enddate = dtpEndDate.Value;

            DataTable dt = new DataTable();
            dt.Columns.Add("Machine", typeof(string));

            double days = (enddate - startdate).TotalDays;

            int i = 0;
            while (i < days)
            {
                dt.Columns.Add(startdate.AddDays(i).ToString().Substring(0, 10), typeof(string));
                i++;
            }

            gvBookings.DataSource = dt;

            int columnsInt = dt.Columns.Count;


            List<string> demonumbers = CC.GetAllDemoNumbers();



            foreach (string s in demonumbers) // For hver maskine (linje)
            {
                dt.Rows.Add(s);
                //for (int j = 0; j < columnsInt; j++)
                //{
                //    if (true)
                //    {

                //    }
                //}

                List<string> bookedDates = CC.GetBookedDates(s);

                foreach (string st in bookedDates) // For hver dato på én maskine
                {
                    for (int k = 1; k < columnsInt; k++) // For hver column-navn
                    {
                        if (st == dt.Columns[k].ToString()) // Hvis dato == column-navn
                        {
                            MessageBox.Show("Booked date: " + st + "in column: " + k);

                            dt.Rows[1].SetColumnError(k, "Booked");
                        }
                    }

                    
                }
                //MessageBox.Show(dt.Columns[1].ToString());
            }
        }
    }
}
