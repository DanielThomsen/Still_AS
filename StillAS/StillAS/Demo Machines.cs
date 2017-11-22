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
            List<string> Demos = CTRC.DropDownDemoLoad();
            foreach(string X in Demos)
            {
                coboDemoMachines.Items.Add(X);
            }
        }

        private void Demo_Maskiner_FormClosing(object sender, EventArgs e)
        {
            
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            //foreach (string X in lbAddedToBooking.Items)
            //{
            //    ControllerClass.DemoMachines.Add(X);
            //}
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

        private void lbAddedToBooking_SelectedIndexChanged(object sender, EventArgs e)
        {

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
    }
}
