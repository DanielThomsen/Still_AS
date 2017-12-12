﻿using System;
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

            List<string> bookingIDs = new List<string>();

            bookingIDs = CC.GetWaiting();

            foreach (string s in bookingIDs)
            {
                lbBookings.Items.Add(s);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            try
            {
                int bookingIDSelected = Convert.ToInt32(lbBookings.SelectedItem);
                ShowBooking SB = new ShowBooking(bookingIDSelected);
                CC.SetBookingID(bookingIDSelected);
                SB.Show();
                
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not found");
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
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
    }
}