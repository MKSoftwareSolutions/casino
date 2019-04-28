using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;




namespace WinCasino
{
    public partial class CashierForm : Form
    {
        private string NameTBText;
        private string SSNTBText;
        private string UnKeyTBText;
        public OleDbConnection myConn;
        int userCount = 0;
        int NameIndex = 0;
        int SSNIndex = 1;
        int UnKey = 2;
        int DepositIndex = 3;
        int BalanceIndex = 4;
        int CodeIndex = 5;
        int UsedIndex = 6;
        int MachineIndex = 7;



        public CashierForm()
        {
            InitializeComponent();
            //ConnectToDB.Connect();
            //myConn = new ConnectToDB();
            //dataGridView1.DataBind();
            var DBPath = Application.StartupPath + "\\CasinoData.mdb";
            myConn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath);
            myConn.Open();
            DataSet myDataSet = new DataSet();
            var myAdapptor = new OleDbDataAdapter("SELECT * FROM Data", myConn);
            DataTable myDT = new DataTable();
            myAdapptor.Fill(myDT);
            dataGridView1.DataSource = myDT;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            NameTBText = CustomerSearchNameTB.Text;
            SSNTBText = CustomerSearchSSNTB.Text;
            UnKeyTBText = NameTBText + SSNTBText;
            label4.Text = UnKeyTBText;
            upDateGrid();


            if (userCount == 1) // user found - just add deposit from gui and data from dt in checkifcustomerexists() 
            {
                
                //SaveDepositButton.Visible = true;
            }
            else
            { // not found - need to add new customer
                //Panel1.Visible = false;
                System.Windows.Forms.MessageBox.Show("User Not Found!");
                button1.Visible = false;

            }
            //Panel2.Visible = true;
            //SaveDepositButton.Visible = false;
            //SaveCustomerButton.Visible = true;
            // FirstNameTextBox2.Text = FirstNameTextBox1.Text;
            //SSNTextBox2.Text = SSNTextBox1.Text;
            // UnKeyTextBox2.Text = UnKeyTextBox1.Text;
            // SaveCustomerButton.Visible = true;
        }

        public void upDateGrid()
        {
               

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                
                label4.Text = UnKeyTBText;
                label1.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();// row.Cells[UnKeyIndex].ToString();




                if (row.Cells[2].Value.ToString() == UnKeyTBText) 
                {
                //  if (string.Compare(row.Cells[UnKeyInddex].Value.ToString(), UnKeyTBText, true) == 0)
                //   {


                //row2.Cells[DepositIndex].Text = DepositTextBox1.Text;
                //int DepositToInt = Convert.ToInt32(DepositTextBox1.Text);
                //int BalanceToInt = Convert.ToInt32(row2.Cells[BalanceIndex].Text);
                //int NewBalance = BalanceToInt + DepositToInt;
                //string newCode = new string(getCode().Take(8).ToArray());  // assign new access code
                //row2.Cells[BalanceIndex].Text = NewBalance.ToString();
                //row2.Cells[CodeIndex].Text = newCode;  // assign new access code
                //row2.Cells[UsedIndex].Text = "No";
                //row2.Cells[MachineIndex].Text = "None";
                //SQLUpdate(DepositTextBox1.Text, NewBalance.ToString(), unkey, newCode);

                userCount = 1;


                //  }
                //   else
                //   {

                //   }
                }
            }
        }

        private void CustomerSearchSSNTB_TextChanged(object sender, EventArgs e)
        {
            UnKeyTBText = CustomerSearchNameTB.Text + CustomerSearchSSNTB.Text;
            CustomerSearchUnKeyTB.Text = UnKeyTBText;
        }

    }
}