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
            btnSaveBooking.Visible = false;
            btnCancel.Visible = false;
            List<TextBox> textBoxList = new List<TextBox>
            {
                txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
                txtSalesRep, txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
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
                customerTextboxes[i].Text = s;
                i++;
            }

            //MessageBox.Show("Booking ID " + bookingID + ", kundeoplysninger:" + allCustomerInfoString);

            // Vis alle bookingoplysninger:
            List<string> booking = CC.GetBooking(bookingID);
            List<TextBox> bookingTextboxes = new List<TextBox>() {txtSalesRep, txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop, txtDeliveryNote};
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

                tbConfigs.Text = configurations;
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
            }
        }

        private void btnBackToBooking_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            CC.RollBackTransaction();
            List<TextBox> textBoxList = new List<TextBox>
            {
                txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
                txtSalesRep, txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
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
                string salesRep = txtSalesRep.Text;
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
                txtPhone, txtSalesRep, txtCarrier, txtMessageToWorkshop, txtDeliveryNote };
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
                else
                {
                    try
                    {
                        CC.UpdateBooking(name1, name2, att, address, zipCode, city, phone,
                            salesRep, deliveryDate, retrievalDate, carrier, messageToWorkshop,
                            deliveryNote, loadingPlatform, bookingID);
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
            CC.BeginTransaction();
            lblShowBooking.Text = "Edit booking";
            btnBackToBooking.Visible = false;
            btnSaveBooking.Visible = true;
            btnEditBooking.Visible = false;
            btnCancel.Visible = true;
            List<TextBox> textBoxList = new List<TextBox>
            {
                txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
                txtSalesRep, txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
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
        }

        private void btnDont_Click(object sender, EventArgs e)
        {
            CC.SetApproval(1);
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
    }
}
