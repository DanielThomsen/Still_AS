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

            List<string> models = CC.GetAllModels();
            cbModel.Items.Add("");
            foreach (string s in models)
            {
                cbModel.Items.Add(s);
            }
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
            try
            {
                gvBookings.DataSource = CC.GetBookingsByDate(dtpDate.Value.Date);

            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
            }
        }

        private void gvBookings_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BookingsOverview_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'stillasDataSet.Booking' table. You can move, or remove it, as needed.
            //this.bookingTableAdapter.Fill(this.stillasDataSet.Booking);

        }

        private void btnShowAllMachines_Click(object sender, EventArgs e)
        {
            List<string> demonumbers = new List<string>();

            try
            {
                if (cbModel.SelectedItem.ToString() == "")
                {
                    demonumbers = CC.GetAllDemoNumbers();
                }
                else
                {
                    try
                    {
                        if (cbType.SelectedItem.ToString() == "")
                        {
                            demonumbers = CC.GetDemoNumbersByModel(cbModel.SelectedItem.ToString());
                        }
                        else
                        {
                            demonumbers = CC.GetDemoNumbersByModelAndNumber(cbModel.SelectedItem.ToString(), cbType.SelectedItem.ToString());
                        }
                    }
                    catch (Exception)
                    {
                        demonumbers = CC.GetDemoNumbersByModel(cbModel.SelectedItem.ToString());
                    }


                }
               
            }
            catch (Exception)
            {
                try
                {
                    demonumbers = CC.GetAllDemoNumbers();
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("Connection error");
                }
            }


            try
            {
                DateTime startdate = dtpStart.Value;
                DateTime enddate = dtpEnd.Value;

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

                i = 0;
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
                                //MessageBox.Show("Booked date: " + st + "in column: " + k);

                                dt.Rows[i].SetColumnError(k, "Booked");
                            }
                        }


                    }

                    i++;
                    //MessageBox.Show(dt.Columns[1].ToString());
                }

                for (int l = 0; l < columnsInt; l++)
                {
                    gvBookings.Columns[l].Width = 70;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Connection error");
                
            }

            
        }

        private void cbModel_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbType.Text = "";
            try
            {
                cbType.Items.Clear();

                if (cbModel.SelectedIndex.ToString() != "")
                {
                    List<string> modelNumbers = CC.GetModelNumbers(cbModel.SelectedItem.ToString());
                    cbType.Items.Add("");

                    foreach (string s in modelNumbers)
                    {
                        cbType.Items.Add(s);
                    }
                }
                
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
            
        }

        private void btnShowBookingsByModel_Click(object sender, EventArgs e)
        {

        }

        //private void button1_Click(object sender, EventArgs e)
        //{
        //    DateTime startdate = dtpStart.Value;
        //    DateTime enddate = dtpEnd.Value;

        //    DataTable dt = new DataTable();
        //    dt.Columns.Add("Machine", typeof(string));

        //    double days = (enddate - startdate).TotalDays;

        //    int i = 0;
        //    while (i < days)
        //    {
        //        dt.Columns.Add(startdate.AddDays(i).ToString().Substring(0, 10), typeof(string));
        //        i++;
        //    }

        //    gvBookings.DataSource = dt;

        //    int columnsInt = dt.Columns.Count;


        //    List<string> demonumbers = CC.GetAllDemoNumbers();


        //    i = 0;
        //    foreach (string s in demonumbers) // For hver maskine (linje)
        //    {
        //        dt.Rows.Add(s);
        //        //for (int j = 0; j < columnsInt; j++)
        //        //{
        //        //    if (true)
        //        //    {

        //        //    }
        //        //}

        //        List<string> bookedDates = CC.GetBookedDates(s);

        //        foreach (string st in bookedDates) // For hver dato på én maskine
        //        {
        //            for (int k = 1; k < columnsInt; k++) // For hver column-navn
        //            {
        //                if (st == dt.Columns[k].ToString()) // Hvis dato == column-navn
        //                {
        //                    //MessageBox.Show("Booked date: " + st + "in column: " + k);

        //                    dt.Rows[i].SetColumnError(k, "Booked");
        //                }
        //            }


        //        }

        //        i++;
        //        //MessageBox.Show(dt.Columns[1].ToString());
        //    }

        //    for (int l = 0; l < columnsInt; l++)
        //    {
        //        gvBookings.Columns[l].Width = 70;
        //    }
        //}
    }
}
