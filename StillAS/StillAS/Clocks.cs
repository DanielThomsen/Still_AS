using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;

namespace StillAS
{
    public partial class Clocks : Form
    {
        ControllerClass CC = new ControllerClass();
        Thread Now;
        Thread NY;
        public delegate void TickTockNow();
        public delegate void TickTockNY();
        
        public Clocks()
        {
            InitializeComponent();
        }

        private void Clocks_Load(object sender, EventArgs e)
        {
            Now = new Thread(TickNow);
            NY = new Thread(TickNY);
            Now.IsBackground = true;
            NY.IsBackground = true;
            Now.Start();
            NY.Start();
        }
        private void UpdateNow()
        {
            lblNow.Text = CC.TimeNow();
        }
        private void UpdateNY()
        {
            lblNY.Text = CC.TimeNY();
        }
        private void TickNow()
        {
            try
            {
                while (true)
                {
                    lblNow.Invoke(new TickTockNow(this.UpdateNow));
                    Thread.Sleep(1000);
                }
            }
            catch
            {

            }
        }
        private void TickNY()
        {
            try
            {
                while (true)
                {
                    lblNY.Invoke(new TickTockNY(this.UpdateNY));
                    Thread.Sleep(1000);
                }
            }
            catch
            {

            }
        }
        private void btnExitProgram_Click(object sender, EventArgs e)
        {
            Now.Abort();
            NY.Abort();
        }
    }
}
