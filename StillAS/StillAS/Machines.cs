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
                int i = 0;
                while (modelname.Count > i)
                {
                    libModelName.Items.Add(modelname[i].ToString()); // INDSÆTTER I LISTBOXEN
                    i++;
                }
                if (i == 0)
                {
                    MessageBox.Show("Connection error");
                }
                
            }
            catch (Exception)
            {

                
            }

        }
        private void btnAddMachine_Click(object sender, EventArgs e)
        {
            try
            {
                if (CC.CheckConnection() == true)
                {
                    AddMachine TM = new AddMachine();
                    TM.Show();
                }
            }
            catch (Exception)
            {

                MessageBox.Show("Connection error");
            }

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
                DialogResult dRes = MessageBox.Show("Are you sure you want to delete Demo Machine " + libDemoNumber.SelectedItem + "?", "Attention!", MessageBoxButtons.YesNo);
                if (dRes == DialogResult.Yes)
                {
                    string demoNumberSelected = libDemoNumber.SelectedItem.ToString();

                try
                {
                    CC.RemoveMachine(demoNumberSelected);
                    MessageBox.Show("Machine with demo number: " + demoNumberSelected + " has been removed");
                }
                catch (Exception)
                {
                    MessageBox.Show("Connection error");
                }

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not chosen");
            }
        }

        private void btnShowMachine_Click(object sender, EventArgs e)
        {
            try
            {
                AddMachine TM = new AddMachine(libDemoNumber.SelectedItem.ToString());

                if (CC.CheckConnection() == true)
                {
                    TM.Show();
                }

                else
                {
                    MessageBox.Show("Connection error");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error: Machine not chosen");

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
                DialogResult dRes = MessageBox.Show("Are you sure you want to delete Model Name " + libModelName.SelectedItem + "?", "Attention!", MessageBoxButtons.YesNo);
                if (dRes == DialogResult.Yes)
                {
                    if (CC.CheckConnection() == true)
                    {
                        CC.RemoveModelName(libModelName.SelectedItem.ToString());
                    }

                    else
                    {
                        MessageBox.Show("Connection error");
                    }
                }
                else if (dRes == DialogResult.No)
                {

                }
            }
            catch (Exception)
            {

                MessageBox.Show("Error: Machine not chosen");

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

        private void libModelNumber_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnBackToMenu_Click(object sender, EventArgs e)
        {
            Frontpage fp = new Frontpage();
            fp.Visible = true;
            this.Visible = false;
        }
    }
}
