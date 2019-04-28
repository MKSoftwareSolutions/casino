using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinCasino
{
    public partial class CustomerSearch : UserControl
    {

        private string NameTBText;
        private string SSNTBText;
        private string UnKeyTBText;


        public CustomerSearch()
        {
            InitializeComponent();
        }


        public string getName
        {
            get { return NameTBText; }
    
        }
        public string getSSN
        {
            get { return SSNTBText; }
    
        }
        public string getUnKey
        {
            get { return UnKeyTBText; }
    
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            NameTBText = CustomerSearchNameTB.Text;
            SSNTBText = CustomerSearchSSNTB.Text;
            UnKeyTBText = CustomerSearchNameTB.Text + CustomerSearchSSNTB.Text; 
            //string uk = UnKeyTBText;
            label4.Visible = true;
           

        }
    }
}
