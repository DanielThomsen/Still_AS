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
        public delegate void TickTockNow();
        public delegate void TickTockNY();
        
        public Clocks()
        {
            InitializeComponent();
        }

        private void Clocks_Load(object sender, EventArgs e)
        {
            Thread Now = new Thread(TickNow);
            Thread NY = new Thread(TickNY);
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
            while(true)
            {
                Thread.Sleep(1000);
                lblNow.Invoke(new TickTockNow(this.UpdateNow));
            }
        }
        private void TickNY()
        {
            while (true)
            {
                Thread.Sleep(1000);
                lblNY.Invoke(new TickTockNY(this.UpdateNY));
            }
        }
        private void Timer()
        {
             
        }
    }
}
