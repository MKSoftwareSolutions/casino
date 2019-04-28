using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WindowsCasino
{
    public partial class Games : Form
    {
        public Games()
        {
            InitializeComponent();
            // I want this form to always open CFlashController
            // with a particular game to load.
            // Send a variable that tells it which game to open
            // depending on which icon is clicked.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CFlashController cfForm = new CFlashController();
            cfForm.Tag = this;
            cfForm.Show(this);
            Hide();
        }
    }
}
