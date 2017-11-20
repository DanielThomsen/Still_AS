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
    public partial class Machines : Form
    {
        ControllerClass CC = new ControllerClass();
        List<string> modelname = new List<string>();
        List<string> modelnumber = new List<string>();
        List<string> demonumber = new List<string>();
        public Machines()
        {
            InitializeComponent();
            CC.PopulateListbox(modelname);
            for (int i = 0; i < modelname.Count; i++)
            {
                libModelName.Items.Add(modelname[i].ToString());
            }
            CC.UpdateNextListbox(libModelName.SelectedItem.ToString());



            // Selection modes, så man kan vælge mere end en ting. 
            libModelName.SelectionMode = SelectionMode.MultiSimple;
            libModelNumber.SelectionMode = SelectionMode.MultiSimple;
            libDemoNumber.SelectionMode = SelectionMode.MultiSimple;
            
        }

        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            TilføjMaskine TM = new TilføjMaskine();
            TM.Show();
        }
    }
}
