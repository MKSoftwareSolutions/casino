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
    public partial class RootMenu : Form
    {
        public RootMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cashier cForm = new Cashier();
            cForm.Tag = this;
            cForm.Show(this);
            Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Games gf = new Games();
            gf.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Cashier cForm = new Cashier();
            cForm.Tag = this;
            cForm.Show(this);
            Hide();
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Games gf = new Games();
            gf.Show();
        }
    }
}