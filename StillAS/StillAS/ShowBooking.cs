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
    public partial class ShowBooking : Form
    {
        ControllerClass CC = new ControllerClass();
        static int BookingIDs;
      
        public ShowBooking(int bookingID)
        {
            InitializeComponent();
            // Leas lille del, der skal være der
            dtpDeliveryDate.Visible = false;
            dtpRetrievalDate.Visible = false;
            coboSalesRep.Enabled = false;
            btnSaveBooking.Visible = false;
            btnCancel.Visible = false;
            List<TextBox> textBoxList = new List<TextBox>
            {
                txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
                txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
                txtDeliveryNote, txtConfigs

            };
            foreach (TextBox t in textBoxList)
            {
                t.ReadOnly = true;
            }
            rbtnNo.Enabled = false;
            rbtnYes.Enabled = false;
            // Vis alle kundeoplysninger:
            List<string> customers = CC.GetCustomer(bookingID);
            List<TextBox> customerTextboxes = new List<TextBox>() { txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone};
            //string allCustomerInfoString = "";

            int i = 0;
            foreach (string s in customers)
            {
                //allCustomerInfoString = allCustomerInfoString + s + ", ";
                if (s == "Denmark" || s == "Sweden")
                {
                    coboCountry.Text = s;
                }
                else
                { 
                customerTextboxes[i].Text = s;
                i++;
                }
            }

            //MessageBox.Show("Booking ID " + bookingID + ", kundeoplysninger:" + allCustomerInfoString);

            // Vis alle bookingoplysninger:      
            List<string> booking = CC.GetBooking(bookingID);
            coboSalesRep.Text = CC.GetOneSalesRep(bookingID);
            List<TextBox> bookingTextboxes = new List<TextBox>() {txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop, txtDeliveryNote};
            //string allBookingInfoString = "";

            i = 0;
            foreach (TextBox t in bookingTextboxes)
            {
                //allBookingInfoString = allBookingInfoString + s + ", ";
                t.Text = booking[i];
                i++;
            }

            if (booking[i] == "1")
            {
                rbtnYes.Checked = true;
                rbtnNo.Checked = false;
            }

            else
            {
                rbtnNo.Checked = true;
                rbtnYes.Checked = false;
            }

            //MessageBox.Show("All booking info: " + allBookingInfoString);

            // Vis alle maskiner på booking:
            List<string> machines = CC.GetMachines(bookingID);
            //string allMachinesInBooking = "";

            foreach (string s in machines)
            {
                //allMachinesInBooking = allMachinesInBooking + s + ", ";
                libBookingMachines.Items.Add(s);
            }

            txtConfigs.Text = CC.GetConfigs(bookingID);
            //MessageBox.Show("All machines in booking: " + allMachinesInBooking);


            //Vis alle konfigurationer på bookings maskiner:

            // Liste af konfigurationer for hver maskine skal hentes og gøres tilgængelig her
            // så de kan indsættes i listboxen der opdateres alt efter hvilken maskine der vælges

            //MessageBox.Show("Form skal åbnes her. Så vises alt om bookingen.");
            BookingIDs = bookingID;

        }

        private void libBookingMachines_Click(object sender, EventArgs e)
        {
            try
            {
                //  libBookingConfigurations.Items.Clear();

                string configurations = "";
                string machine = libBookingMachines.SelectedItem.ToString();

                configurations = CC.GetConfigurations(machine);

                txtConfigs.Text = configurations;
                //  foreach (string s in configurations)
                //  {
                ////      libBookingConfigurations.Items.Add(s);
                //  }
            }
            catch (Exception)
            {

                
            }
         
        }

        private void ShowBooking_Load(object sender, EventArgs e)
        {
            if (CC.AccessLevel() == 1)
            {
                btnApprove.Visible = false;
                btnDont.Visible = false;
            }
            if (CC.AccessLevel() == 2)
            {
                btnEditBooking.Visible = false;
                btnSaveBooking.Visible = false;
                btnCancel.Visible = false;
                btnApprove.Visible = false;
                btnDont.Visible = false;
            }
            else if (CC.AccessLevel() == 3)
            {
                btnEditBooking.Visible = false;
                btnSaveBooking.Visible = false;
                btnCancel.Visible = false;
                btnBackToBooking.Visible = false;
            }
            else if (CC.AccessLevel() == 4)
            {
                btnEditBooking.Visible = false;
                btnSaveBooking.Visible = false;
                btnCancel.Visible = false;
                btnApprove.Visible = false;
                btnDont.Visible = false;
            }
            int bookingID = BookingIDs;
            coboCountry.Enabled = false;            
            coboCountry.Text = CC.GetCountry(bookingID);
        }

        private void btnBackToBooking_Click(object sender, EventArgs e)
        {
            if (CC.AccessLevel() != 4)
            {
                Bookings bookings = new Bookings();
                bookings.Show();
            }

            this.Visible = false;

        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            int bookingID = BookingIDs;
            dtpDeliveryDate.Visible = false;
            dtpRetrievalDate.Visible = false;
            txtDeliveryDate.Visible = true;
            txtRetrievalDate.Visible = true;
            coboCountry.Enabled = false;
            coboCountry.Text = CC.GetCountry(bookingID);
            coboSalesRep.Enabled = false;
            coboSalesRep.Text = CC.GetOneSalesRep(bookingID);
            List<TextBox> textBoxList = new List<TextBox>
            {
                txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
                txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
                txtDeliveryNote, txtConfigs

            };
            foreach (TextBox t in textBoxList)
            {
                t.ReadOnly = true;
            }
            rbtnNo.Enabled = false;
            rbtnYes.Enabled = false;
            btnCancel.Visible = false;
            btnSaveBooking.Visible = false;
            btnEditBooking.Visible = true;
            btnBackToBooking.Visible = true;
        }      

        private void btnSaveBooking_Click(object sender, EventArgs e)
        {
            try
            {
                string name1 = txtName1.Text;
                string name2 = txtName2.Text;
                string att = txtATT.Text;
                string address = txtAdresss.Text;
                string zipCode = txtZipCode.Text;
                string city = txtCity.Text;
                string phone = txtPhone.Text;
                string country = coboCountry.Text;
                string salesRep = coboSalesRep.Text;
                string dDate = txtDeliveryDate.Text;
                string rDate = txtRetrievalDate.Text;
                string deliveryDate = dDate.Substring(0, 10);
                string retrievalDate = rDate.Substring(0, 10);
                string carrier = txtCarrier.Text;
                string messageToWorkshop = txtMessageToWorkshop.Text;
                string deliveryNote = txtDeliveryNote.Text;
                string loadingPlatform;
                if (rbtnYes.Checked == true)
                {
                    loadingPlatform = "1";
                }

                else
                {
                    loadingPlatform = "0";
                }
                int bookingID = BookingIDs;
                List<TextBox> textBoxList = new List<TextBox>
            { txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity,
                txtPhone, txtCarrier, txtMessageToWorkshop, txtDeliveryNote };
                foreach (TextBox t in textBoxList)
                {
                    if (String.IsNullOrEmpty(t.Text))
                    {
                        MessageBox.Show("Please fill out empty boxes");
                        return;
                    }
                }
                if (String.IsNullOrEmpty(deliveryDate))
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else if (String.IsNullOrEmpty(retrievalDate))
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else if (libBookingMachines.Items.Count <= 0)
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else if (String.IsNullOrEmpty(coboCountry.Text))
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else if (String.IsNullOrEmpty(coboSalesRep.Text))
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else
                {
                    try
                    {
                        CC.UpdateBooking(name1, name2, att, address, zipCode, city, phone, country,
                            salesRep, deliveryDate, retrievalDate, carrier, messageToWorkshop,
                            deliveryNote, loadingPlatform, bookingID);
                        btnSaveBooking.Visible = false;
                        btnCancel.Visible = false;
                        btnEditBooking.Visible = true;
                        btnBackToBooking.Visible = true;
                        foreach (TextBox t in textBoxList)
                        {
                            t.ReadOnly = true;
                        }
                        coboCountry.Enabled = false;
                        coboSalesRep.Enabled = false;
                        txtDeliveryDate.ReadOnly = true;
                        txtRetrievalDate.ReadOnly = true;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
            catch
            {

            }
           
        }

        private void btnEditBooking_Click_1(object sender, EventArgs e)
        {
            coboCountry.Items.Clear();
            coboSalesRep.Items.Clear();
            txtDeliveryDate.Visible = false;
            txtRetrievalDate.Visible = false;
            dtpDeliveryDate.Visible = true;
            dtpRetrievalDate.Visible = true;
            int bookingID = BookingIDs;
            int i = 0;
            List<string> getDates = CC.GetDates(bookingID);
            List<DateTimePicker> Dates = new List<DateTimePicker> { dtpDeliveryDate, dtpRetrievalDate };
            foreach (DateTimePicker dtp in Dates)
            {
                dtp.Text = getDates[i];
                i++;
            }
            List<string> SalesRep = new List<string>();
            CC.GetAllSalesRep(SalesRep);
            foreach (string s in SalesRep)
            {
                coboSalesRep.Items.Add(s);
            }
            coboSalesRep.Enabled = true;
            coboSalesRep.DropDownStyle = ComboBoxStyle.DropDownList;
            coboSalesRep.Text = CC.GetOneSalesRep(bookingID);
            coboCountry.Items.Add("Denmark");
            coboCountry.Items.Add("Sweden");
            coboCountry.Enabled = true;
            coboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            coboCountry.Text = CC.GetCountry(bookingID);
            lblShowBooking.Text = "Edit booking";
            btnBackToBooking.Visible = false;
            btnSaveBooking.Visible = true;
            btnEditBooking.Visible = false;
            btnCancel.Visible = true;
            List<TextBox> textBoxList = new List<TextBox>
            {
                txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
                txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
                txtDeliveryNote, txtConfigs

            };
            foreach (TextBox t in textBoxList)
            {
                t.ReadOnly = false;
            }
            rbtnYes.Enabled = true;
            rbtnNo.Enabled = true;
        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            CC.SetApproval(0);
            WorkshopBookings WB = new WorkshopBookings();
            WB.Show();
            this.Visible = false;
        }

        private void btnDont_Click(object sender, EventArgs e)
        {
            CC.SetApproval(1);
            WorkshopBookings WB = new WorkshopBookings();
            WB.Show();
            this.Visible = false;
        }

        private void txtZipCode_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void viewHelpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string filename = "Hjælpedokument.pdf";
            System.Diagnostics.Process.Start(@filename);
        }
    }
}
