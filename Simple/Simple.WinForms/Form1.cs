using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple.WinForms
{
    public partial class SimpleWinForm : Form
    {
        public SimpleWinForm()
        {
            InitializeComponent();

            Timer updateTimer = new Timer()
            {
                Enabled = true,
                Interval = 100,                
            };

            updateTimer.Tick += updateTimerTick;

            this.btnToggleCounter.Text = Program.Hans.prgSimple._counterActive.Synchron ? "Stop counting" : "Start counting";
        }

        private void updateTimerTick(object sender, EventArgs e)
        {
            this.tbCounterValue.ReadOnly = true;
            this.tbCounterValue.Text = Program.Hans.prgSimple._counter.Cyclic.ToString();
        }

        private void btnToggleCounter_Click(object sender, EventArgs e)
        {
            Program.Hans.prgSimple._counterActive.Synchron = !Program.Hans.prgSimple._counterActive.Synchron;

            this.btnToggleCounter.Text = Program.Hans.prgSimple._counterActive.Synchron ? "Stop counting" : "Start counting";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Program.Hans.prgSimple._reset.Synchron = true;
        }
    }
}
