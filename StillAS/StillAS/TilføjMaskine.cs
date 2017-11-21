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
    public partial class TilføjMaskine : Form
    {
        ControllerClass CC = new ControllerClass();        
        public TilføjMaskine()
        {
            InitializeComponent();

        }

        public TilføjMaskine(string demoNumber)
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
            int i = 0;
            foreach (TextBox tb in textBoxList)
            {
                tb.Text = machineInfo[i];
                i++;
            }
        }

        private void btnSaveMachine_Click(object sender, EventArgs e)
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
            decimal Weight = Convert.ToDecimal(txtWeight.Text.Replace('.' , ','));
            decimal Height = Convert.ToDecimal(txtHeight.Text.Replace('.', ','));
            decimal Length = Convert.ToDecimal(txtLength.Text.Replace('.', ','));
            decimal Width = Convert.ToDecimal(txtWidth.Text.Replace('.', ','));
            CC.CreateMachine(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber, 
                             Controller, Weight, Height, Length, Width);
            
        }
    }
}
