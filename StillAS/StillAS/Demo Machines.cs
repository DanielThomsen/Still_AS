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
        }
    }
}
