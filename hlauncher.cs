using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Half_Life_Launcher
{
    public partial class hlauncher : Form
    {
        public hlauncher()
        {
            InitializeComponent();
        }

        private void Bshift_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://rungameid/130");
        }

        private void Valve_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://rungameid/70");
        }

        private void Gearbox_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process.Start("steam://rungameid/50");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Advanced_Click(object sender, EventArgs e)
        {
            _ = advanced.Enabled = false;
        }
    }
}
