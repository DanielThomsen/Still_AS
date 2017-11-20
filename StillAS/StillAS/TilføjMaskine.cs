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
            CC.CreateMachine(DemoNumber, ModelName, ModelNumber, Brand, CNumber, MastType, MastBuildingHeight, MastLiftHeight,
                             MastFreeLift, AggregatType, AggregatNumber, BatteryType, BatteryNumber, ChargerType, ChargerNumber, 
                             Controller);

        }
    }
}
