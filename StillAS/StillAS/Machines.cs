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
        protected List<string> modelname = new List<string>();
        protected List<string> modelnumber = new List<string>();
        protected List<string> demonumber = new List<string>();
        public Machines() // Når formen loader
        {
            InitializeComponent();

            try
            {
                CC.PopulateListbox(modelname); // HENTER DATA FRA DATABASEN OG SENDER DET OP I EN LISTE
                for (int i = 0; i < modelname.Count; i++)
                {
                    libModelName.Items.Add(modelname[i].ToString()); // INDSÆTTER I LISTBOXEN
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }

        }
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            AddMachine TM = new AddMachine();
            TM.Show();
        }

        private void libModelName_Click(object sender, EventArgs e)
        {
            try
            {
                modelnumber.Clear();
                libModelNumber.Items.Clear();
                string modelname = libModelName.SelectedItem.ToString();
                if (libModelName.SelectedIndex != -1)
                {
                    CC.UpdateSecondListbox(modelname, modelnumber);
                    string count = "";
                    foreach (var item in modelnumber)
                    {
                        if (item == count)
                        {

                        }
                        else
                        {
                            libModelNumber.Items.Add(item);
                            count = item;
                        }
                    }
                }
            }
            catch (Exception)
            {


            }

        }
        private void libModelNumber_Click(object sender, EventArgs e)
        {
            try
            {
                demonumber.Clear();
                libDemoNumber.Items.Clear();
                string modelnumber = libModelNumber.SelectedItem.ToString();

                try
                {
                    if (libModelNumber.SelectedIndex != -1)
                    {
                        CC.UpdateThirdListbox(modelnumber, demonumber);

                        for (int i = 0; i < demonumber.Count; i++)
                        {
                            libDemoNumber.Items.Add(demonumber[i].ToString());
                        }
                    }
                }
                catch (Exception)
                {

                    MessageBox.Show("Connection error");
                }
            }
            catch (Exception)
            {


            }

        }

        private void btnRemoveMachine_Click(object sender, EventArgs e)
        {
            try
            {
                string demoNumberSelected = libDemoNumber.SelectedItem.ToString();

                try
                {
                    CC.RemoveMachine(demoNumberSelected);
                    MessageBox.Show("Machine removed: Demo number:" + demoNumberSelected);
                }
                catch (Exception)
                {

                    MessageBox.Show("Error");
                }

            }
            catch (Exception)
            {
              
            }
        }

        private void btnShowMachine_Click(object sender, EventArgs e)
        {
            try
            {
                string s = libDemoNumber.SelectedItem.ToString();
                AddMachine TM = new AddMachine(libDemoNumber.SelectedItem.ToString());
                TM.Show();
            }
            catch (Exception)
            {
                MessageBox.Show("Choose a machine to show it");

            }
        }

        private void Machines_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddModelName AMN = new AddModelName();
            AMN.Show();
        }

        private void btnRemove_Click(object sender, EventArgs e)
        {
            try
            {
                CC.RemoveModelName(libModelName.SelectedItem.ToString());
            }
            catch (Exception)
            {

                MessageBox.Show("Error");
            }
            
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            try
            {
                modelname.Clear();
                libModelName.Items.Clear();
                libModelNumber.Items.Clear();
                libDemoNumber.Items.Clear();
                CC.PopulateListbox(modelname); // HENTER DATA FRA DATABASEN OG SENDER DET OP I EN LISTE
                for (int i = 0; i < modelname.Count; i++)
                {
                    libModelName.Items.Add(modelname[i].ToString()); // INDSÆTTER I LISTBOXEN
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }


        }

        private void btnShowAvailability_Click(object sender, EventArgs e)
        {

        }
    }
}
