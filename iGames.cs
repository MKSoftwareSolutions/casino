using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCasino
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
        }

        private void Machine1Icon_Click(object sender, EventArgs e)
        {
            MachineNo1 machineNo1 = new MachineNo1();
            machineNo1.Tag = this;
            machineNo1.Show(this);
        }


    }
}
