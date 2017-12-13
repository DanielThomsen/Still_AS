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
    public partial class Demo_Maskiner : Form
    {
        ControllerClass CTRC = new ControllerClass();
        public Demo_Maskiner()
        {
            InitializeComponent();
        }

        private void Demo_Maskiner_Load(object sender, EventArgs e)
        {
            coboCountry.DropDownStyle = ComboBoxStyle.DropDownList;
            coboSalesRep.DropDownStyle = ComboBoxStyle.DropDownList;
            List<string> Demos = CTRC.DropDownDemoLoad();
            List<string> AllSalesRep = new List<string>();
            foreach(string X in Demos)
            {
                coboDemoMachines.Items.Add(X);
            }
            rbtnNo.Checked = true;
            coboCountry.Items.Add("Denmark");
            coboCountry.Items.Add("Sweden");
            CTRC.GetAllSalesRep(AllSalesRep);
            foreach (string s in AllSalesRep)
            {
                coboSalesRep.Items.Add(s);
            }
        }

        private void Demo_Maskiner_FormClosing(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (string X in lbAddedToBooking.Items)
                {
                    ControllerClass.DemoMachines.Add(X);
                }
                string Name1 = txtName1.Text;
                string Name2 = txtName2.Text;
                string Att = txtATT.Text;
                string Address = txtAdresss.Text;
                string Country = coboCountry.Text;
                int ZIP = Convert.ToInt32(txtZipCode.Text);
                string City = txtCity.Text;
                int Phone = Convert.ToInt32(txtPhone.Text);
                int Selected;

                if (rbtnYes.Checked == true)
                {
                    Selected = 0;
                }

                else
                {
                    Selected = 1;
                }
                string salesRep = coboSalesRep.Text;
                string Date1 = dtpDeliveryDate.Value.ToShortDateString();
                string Date2 = dtpRetrievalDate.Value.ToShortDateString();
                string Transporter = txtCarrier.Text;
                string Message1 = txtMessageToWorkshop.Text;
                string Message2 = txtDeliveryNote.Text;
                string Konfig = txtKonfig.Text;
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
                if (String.IsNullOrEmpty(Date1))
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else if (String.IsNullOrEmpty(Date2))
                {
                    MessageBox.Show("Please fill out empty boxes");
                    return;
                }
                else if (lbAddedToBooking.Items.Count <= 0)
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
                    CTRC.AddCustomer(Name1, Name2, Att, Address, ZIP, City, Country, Phone);
                    CTRC.CreateBooking(salesRep, Date1, Date2, Transporter, Message1, Message2, Selected);
                    CTRC.CreateBookingLine(Konfig);
                    this.Visible = false;
                }
            }
            catch
            {

            }
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                lbAddedToBooking.Items.Add(coboDemoMachines.SelectedItem);
                coboDemoMachines.Items.Remove(coboDemoMachines.SelectedItem);
                if (coboDemoMachines.Items.Count == 0)
                {
                    coboDemoMachines.Text = string.Empty;
                    btnAdd.Enabled = false;
                    coboDemoMachines.Enabled = false; 
                }
            }
            catch
            {
                MessageBox.Show("Please choose a machine");
            }
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                coboDemoMachines.Items.Add(lbAddedToBooking.SelectedItem);
                coboDemoMachines.Enabled = true;
                btnAdd.Enabled = true;
                lbAddedToBooking.Items.Remove(lbAddedToBooking.SelectedItem);
            }
            catch
            {
                MessageBox.Show("Please select a machine to remove");
            }
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
