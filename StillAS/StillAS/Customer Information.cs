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
    public partial class Customer_Information : Form
    {
        ControllerClass CTRC = new ControllerClass();
        public Customer_Information()
        {
            InitializeComponent();
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            string Name1 = txtName1.Text;
            string Name2 = txtName2.Text;
            string Att = txtAtt.Text;
            string Address = txtAddress.Text;
            int ZIP = Convert.ToInt32(txtZIPCode.Text);
            string City = txtCity.Text;
            int Phone = Convert.ToInt32(txtPhone.Text);
            CTRC.AddCustomer(Name1, Name2, Att, Address, ZIP, City, Phone);
            Delivery Del = new Delivery();
            Del.Show();
        }
    }
}
