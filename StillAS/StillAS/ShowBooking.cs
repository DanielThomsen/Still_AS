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
        public ShowBooking()
        {
            InitializeComponent();
        }

        public ShowBooking(int bookingID)
        {
            InitializeComponent();

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
        }

        private void libBookingMachines_Click(object sender, EventArgs e)
        {
            libBookingConfigurations.Items.Clear();

            List<string> configurations = new List<string>();
            string machine = libBookingMachines.SelectedItem.ToString();

            configurations = CC.GetConfigurations(machine);

            foreach (string s in configurations)
            {
                libBookingConfigurations.Items.Add(s);
            }
        }

        private void ShowBooking_Load(object sender, EventArgs e)
        {
            if (CC.AccessLevel() == 2)
            {
                btnEditBooking.Visible = false;
                btnSaveBooking.Visible = false;
                btnCancel.Visible = false;
            }
            else if (CC.AccessLevel() == 3)
            {
                btnEditBooking.Visible = false;
                btnSaveBooking.Visible = false;
                btnCancel.Visible = false;
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
        //    ControllerClass CC = new ControllerClass();
        //    public ShowBooking()
        //    {
        //        InitializeComponent();
        //        btnSaveBooking.Visible = false;
        //        btnCancel.Visible = false;
        //        List<TextBox> textBoxList = new List<TextBox>
        //        {
        //            txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
        //            txtSalesRep, txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
        //            txtDeliveryNote

        //        };
        //        foreach (TextBox t in textBoxList)
        //        {
        //            t.ReadOnly = true;
        //        }
        //    }

        //    private void btnEditBooking_Click(object sender, EventArgs e)
        //    {
        //        lblShowBooking.Text = "Edit booking";
        //        btnBackToBooking.Visible = false;
        //        btnSaveBooking.Visible = true;
        //        btnEditBooking.Visible = false;
        //        btnCancel.Visible = true;
        //        List<TextBox> textBoxList = new List<TextBox>
        //        {
        //            txtName1, txtName2, txtATT, txtAdresss, txtZipCode, txtCity, txtPhone,
        //            txtSalesRep, txtDeliveryDate, txtRetrievalDate, txtCarrier, txtMessageToWorkshop,
        //            txtDeliveryNote

        //        };
        //        CC.BeginTransaction();
        //        foreach (TextBox t in textBoxList)
        //        {
        //            t.ReadOnly = false;
        //        }            
        //    }
    }
}
