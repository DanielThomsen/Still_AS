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
    public partial class AddMachine : Form
    {
        ControllerClass CC = new ControllerClass();        
        public AddMachine()
        {
            InitializeComponent();
            cbConfigurations.Visible = true;
            libConfigurations.Visible = false;
            List<string> configurationsList = CC.GetAllConfigurations();

            foreach (string s in configurationsList)
            {
                cbConfigurations.Items.Add(s);
            }
            btnSaveMachine.Visible = false;

    }

        public AddMachine(string demoNumber)
        {
            InitializeComponent();
            List<string> machineInfo = CC.ShowMachine(demoNumber);
            List<TextBox> textBoxList = new List<TextBox>
            { txtModelName, txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
            txtDemoMachine.Text = demoNumber;
            List<string> configurations = CC.GetConfigurations(demoNumber);

            txtDemoMachine.ReadOnly = true; // -- Lea
            int i = 0;
            foreach (TextBox tb in textBoxList)
            {
                tb.Text = machineInfo[i];
                tb.ReadOnly = true; // -- Lea
                i++;
            }

            foreach (string s in configurations)
            {
                libConfigurations.Items.Add(s);
            }
            lblAddMachineTitle.Text = "Show Machine";
        }
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            string DemoNumber = txtDemoMachine.Text;
            string ModelName = txtModelName.Text;
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
            foreach (object itemChecked in cbConfigurations.CheckedItems)
            {
                configurationsList.Add(itemChecked + "");
            }

            CC.CreateMachine(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber,
                             Controller, Weight, Height, Length, Width);
        }
        // Lea arbejder herfra ---- >
        public string oldDemoNumber;
        private void btnEditMachine_Click(object sender, EventArgs e)
        {
            lblAddMachineTitle.Text = "Edit Machine";
            oldDemoNumber = txtDemoMachine.Text;
            btnAddMachine.Visible = false;
            btnSaveMachine.Visible = true;
            List<TextBox> textBoxList = new List<TextBox>
            { txtDemoMachine, txtModelName, txtModelNumber,
                txtBrand, txtChassisNumber, txtMastType, txtMastBuildingHeight,
                txtMastLiftingHeight, txtMastFreeLift, txtAggregateType,
                txtAggregateNumber, txtBatteryType, txtBatteryNumber, txtChargerType,
                txtChargerNumber, txtController, txtWeight, txtHeight, txtLength,
                txtWidth };
            foreach (TextBox tb in textBoxList)
            {
                tb.ReadOnly = false;
            }
        }
        private void btnSaveMachine_Click(object sender, EventArgs e)
        {
            string messagebox = "";
            string DemoNumber = txtDemoMachine.Text;
            string ModelName = txtModelName.Text;
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
            string hent = CC.UpdateInformation(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber,
                             Controller, Weight, Height, Length, Width, oldDemoNumber, messagebox);
            MessageBox.Show(hent);

                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber, 
                             Controller, Weight, Height, Length, Width, configurationsList);
            
        }

    }
}
