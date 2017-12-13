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
    public partial class AddMachine : Form
    {
        ControllerClass CC = new ControllerClass();
        public AddMachine()
        {
            InitializeComponent();
            btnSaveMachine.Visible = false;
            btnEditMachine.Visible = false;
        }

        public AddMachine(string demoNumber)
        {
            InitializeComponent();
            List<string> machineInfo = CC.ShowMachine(demoNumber);
            List<TextBox> textBoxList = new List<TextBox>
            { txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
            cbModelName.Enabled = false;
            cbModelName.Text = CC.GetModelName(demoNumber);
            txtDemoMachine.Text = demoNumber;
            
            txtDemoMachine.ReadOnly = true; // -- Lea
            int i = 0;
            foreach (TextBox tb in textBoxList)
            {
                tb.Text = machineInfo[i];
                tb.ReadOnly = true; // -- Lea
                i++;
            }

            btnAddMachine.Visible = false;
            btnSaveMachine.Visible = false;
            btnEditMachine.Visible = true;
        }
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                string DemoNumber = txtDemoMachine.Text;
                string ModelName = cbModelName.Text;
                string ModelNumber = txtModelNumber.Text;
                string Brand = txtBrand.Text;
                string CNumber = txtChassisNumber.Text;
                string MastType = txtMastType.Text;
                int MastBuildingHeight = Convert.ToInt32(txtMastBuildingHeight.Text);
                int MastLiftHeight = Convert.ToInt32(txtMastLiftingHeight.Text);
                int MastFreeLift = Convert.ToInt32(txtMastFreeLift.Text);
                string AggregatType = txtAggregateType.Text;
                string AggregatNumber = txtAggregateNumber.Text;
                string BatteryType = txtBatteryType.Text;
                string BatteryNumber = txtBatteryNumber.Text;
                string ChargerType = txtChargerType.Text;
                string ChargerNumber = txtChargerNumber.Text;
                string Controller = txtController.Text;
                decimal Weight = Convert.ToDecimal(txtWeight.Text.Replace('.', ','));
                decimal Height = Convert.ToDecimal(txtHeight.Text.Replace('.', ','));
                decimal Length = Convert.ToDecimal(txtLength.Text.Replace('.', ','));
                decimal Width = Convert.ToDecimal(txtWidth.Text.Replace('.', ','));

                List<string> configurationsList = new List<string>();
                List<TextBox> textBoxList = new List<TextBox>
            { txtDemoMachine, txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
                foreach (TextBox t in textBoxList)
                {
                    if (String.IsNullOrEmpty(t.Text))
                    {
                        MessageBox.Show("Please fill all empty boxes");
                    }
                }
                if (String.IsNullOrEmpty(ModelName))
                {
                    MessageBox.Show("Please fill all empty boxes");
                }

                try
                {
                    CC.CreateMachine(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                                 MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber,
                                 Controller, Weight, Height, Length, Width, configurationsList);
                }
                catch (Exception)
                {

                    MessageBox.Show("Connection error");
                }

            }

            catch { }
        }
            
        // Lea arbejder herfra ---- >
        public string oldDemoNumber;
        private void btnEditMachine_Click(object sender, EventArgs e)
        {
            oldDemoNumber = txtDemoMachine.Text;
            btnAddMachine.Visible = false;
            btnSaveMachine.Visible = true;
            List<TextBox> textBoxList = new List<TextBox>
            { txtDemoMachine, txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
            foreach (TextBox tb in textBoxList)
            {
                tb.ReadOnly = false;
            }
            cbModelName.Enabled = true;
            btnEditMachine.Visible = false;
            btnSaveMachine.Visible = true;
        }
        private void btnSaveMachine_Click(object sender, EventArgs e)
        {
            string DemoNumber = txtDemoMachine.Text;
            string ModelName = cbModelName.Text;
            string ModelNumber = txtModelNumber.Text;
            string Brand = txtBrand.Text;
            string CNumber = txtChassisNumber.Text;
            string MastType = txtMastType.Text;
            int MastBuildingHeight = Convert.ToInt32(txtMastBuildingHeight.Text);
            int MastLiftHeight = Convert.ToInt32(txtMastLiftingHeight.Text);
            int MastFreeLift = Convert.ToInt32(txtMastFreeLift.Text);
            string AggregatType = txtAggregateType.Text;
            string AggregatNumber = txtAggregateNumber.Text;
            string BatteryType = txtBatteryType.Text;
            string BatteryNumber = txtBatteryNumber.Text;
            string ChargerType = txtChargerType.Text;
            string ChargerNumber = txtChargerNumber.Text;
            string Controller = txtController.Text;
            decimal Weight = Convert.ToDecimal(txtWeight.Text.Replace('.', ','));
            decimal Height = Convert.ToDecimal(txtHeight.Text.Replace('.', ','));
            decimal Length = Convert.ToDecimal(txtLength.Text.Replace('.', ','));
            decimal Width = Convert.ToDecimal(txtWidth.Text.Replace('.', ','));

            List<TextBox> textBoxList1 = new List<TextBox>
            { txtDemoMachine, txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
            foreach (TextBox t in textBoxList1)
            {
                if (String.IsNullOrEmpty(t.Text))
                {
                    MessageBox.Show("Please fill all empty boxes");
                    return;
                }
            }
            if (String.IsNullOrEmpty(ModelName))
            {
                MessageBox.Show("Please fill all empty boxes");
                return;
            }

            try
            {
                CC.CheckConnection();
                CC.UpdateInformation(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber,
                             Controller, Weight, Height, Length, Width, oldDemoNumber);
                List<TextBox> textBoxList = new List<TextBox>
            { txtDemoMachine, txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
                foreach (TextBox tb in textBoxList)
                {
                    tb.ReadOnly = true;
                }
                cbModelName.Enabled = false;
                btnSaveMachine.Visible = false;
                btnEditMachine.Visible = true;
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }
            
        
        }
        private void AddMachine_Load(object sender, EventArgs e)
        {
            List<string> cb = new List<string>();
            cb = CC.PopulateListbox(cb);
            foreach (string X in cb)
            {
                cbModelName.Items.Add(X);
            }
            
            if (CC.AccessLevel() == 2)
            {
                btnEditMachine.Visible = false;
                btnAddMachine.Visible = false;
                btnSaveMachine.Visible = false;
            }
        }

        private void txtMastBuildingHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMastLiftingHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtMastFreeLift_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtWeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c == 46 && txtWeight.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void txtHeight_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c == 46 && txtHeight.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void txtLength_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c == 46 && txtLength.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }

        private void txtWidth_KeyPress(object sender, KeyPressEventArgs e)
        {
            char c = e.KeyChar;

            if (c == 46 && txtWidth.Text.IndexOf('.') != -1)
            {
                e.Handled = true;
                return;
            }
            if (!Char.IsDigit(c) && c != 8 && c != 46)
            {
                e.Handled = true;
            }
        }
    }
}
