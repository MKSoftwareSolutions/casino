using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.OleDb;

namespace WindowsCasino
{
    public partial class Cashier : Form
    {
        public string connString;
        public string query;
        public OleDbDataAdapter dAdapter;
        public DataTable dTable;
        public OleDbCommandBuilder cBuilder;
        public DataView myDataView;
        public OleDbConnection xyz;
        string FirstName;
        string SSN;
        string UnKey;
        string Deposit;
        string Balance;
        string Code;
        string PassKey;
        string Used = "false";
        string Machine = "None";
        string DateS;
        string LookingForNewCode = "0";


        public Cashier()
        {
            InitializeComponent();

            var DBPath = "C:\\Data\\CasinoData.mdb";//Application.StartupPath + 
            connString = "provider= Microsoft.ACE.OLEDB.12.0;" + "Data Source=" + DBPath;
            query = "SELECT * FROM Data";
            dAdapter = new OleDbDataAdapter(query, connString);
            dTable = new DataTable();
            cBuilder = new OleDbCommandBuilder(dAdapter);
            cBuilder.QuotePrefix = "[";
            cBuilder.QuoteSuffix = "]";
            myDataView = dTable.DefaultView;
            dAdapter.Fill(dTable);
            BindingSource bndSource = new BindingSource();
            bndSource.DataSource = dTable;
            this.dataGridView1.DataSource = bndSource;
            for (int q = 0; q <= dataGridView1.ColumnCount - 1; q++)
            {
                this.filterCB.Items.Add(this.dataGridView1.Columns[q].HeaderText.ToString());
            }
            xyz = new OleDbConnection(connString);
            xyz.Open();
            DataTable tbl = xyz.GetSchema("Tables");
            DataView tbl_dv = tbl.DefaultView;
        }

        private void Cell_Update(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dAdapter.Update(dTable);
                this.textBox2.Text = "Updated " + System.DateTime.Now.ToString();
            }
            catch (OleDbException f)
            {
                this.textBox2.Text = "Not Updated " + f.Source.ToString();
            }
            xyz.Close();
        }





        private void button1_Click(object sender, EventArgs e)
        {
            string mystr;
            addCustomerBTN.Visible = true;


            try
            {
                using (var obj = new Cashier())
                {
                    if (myDataView.RowFilter == "")
                    {
                        mystr = "[" + filterCB.Text + "]";
                        mystr += " = '" + filterTB.Text + "'";
                        myDataView.RowFilter = mystr;
                    }
                    else
                    {
                        mystr = myDataView.RowFilter + " and ";
                        mystr += "[" + dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString() + "]";
                        mystr += " = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                        myDataView.RowFilter = mystr;
                    }

                }
            }
            catch (Exception ex)
            {
                string message = "Error!";
                MessageBox.Show(message + ex.ToString());
            }



            xyz.Close();
        }



 

        private void work_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;


            if (WindowState == FormWindowState.Normal)
            {

                WindowState = FormWindowState.Maximized;

            }

            textBox2.Text = "No messages at this time";
            // UpdateButton.Visible = false;
            //SaveCustomerButton.Visible = false;
        }

        public void customerSideMenuButtonChanged()
        {

            //clear other customer panels
            if (addCustomerGB.Visible == true)
            {
                addCustomerGB.Visible = false;
            }
            if (findCustomerGB.Visible == true)
            {
                findCustomerGB.Visible = false;
            }

        }

        public void codeSideMenuButtonChanged()
        {

            //clear other customer panels
            if (getNewAccessCodeGB.Visible == true)
            {
                getNewAccessCodeGB.Visible = false;
            }
            if (findAccessCodeGB.Visible == true)
            {
                findAccessCodeGB.Visible = false;
            }

        }




        private void findCodeBTN_Click(object sender, EventArgs e)
        {
            codeSideMenuButtonChanged();
            findAccessCodeGB.Visible = true;
        }

        private void getNewCodeBTN_Click(object sender, EventArgs e)
        {
            codeSideMenuButtonChanged();
            getNewAccessCodeGB.Visible = true;
        }

        private void setFilterBTN_Click(object sender, EventArgs e)
        {
            string mystr;
            addCustomerBTN.Visible = true;


            try
            {
                using (var obj = new Cashier())
                {
                    if (myDataView.RowFilter == "")
                    {
                        mystr = "[" + filterCB.Text + "]";
                        mystr += " = '" + filterTB.Text + "'";
                        myDataView.RowFilter = mystr;
                    }
                    else
                    {
                        mystr = myDataView.RowFilter + " and ";
                        mystr += "[" + dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString() + "]";
                        mystr += " = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                        myDataView.RowFilter = mystr;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Error!";
                MessageBox.Show(message + ex.ToString());
            }



            xyz.Close();
        }

        private void addCustomerBTN_Click_1(object sender, EventArgs e)
        {
            // customerSideMenuButtonChanged();
            findCustomerGB.Visible = false;
            addCustomerGB.Visible = true;
        }

        private void findCustomerBTN_Click(object sender, EventArgs e)
        {
            findCustomerGB.Visible = true;
        }

        private void setFilterBTN_Click_1(object sender, EventArgs e)
        {
            string mystr;
            addCustomerBTN.Visible = true;


            try
            {
                using (var obj = new Cashier())
                {
                    if (myDataView.RowFilter == "")
                    {
                        mystr = "[" + filterCB.Text + "]";
                        mystr += " = '" + filterTB.Text + "'";
                        myDataView.RowFilter = mystr;
                    }
                    else
                    {
                        mystr = myDataView.RowFilter + " and ";
                        mystr += "[" + dataGridView1.CurrentCell.OwningColumn.HeaderText.ToString() + "]";
                        mystr += " = '" + dataGridView1.CurrentCell.Value.ToString() + "'";
                        myDataView.RowFilter = mystr;
                    }
                }
            }
            catch (Exception ex)
            {
                string message = "Error!";
                MessageBox.Show(message + ex.ToString());
            }



            xyz.Close();
        }

        private void clearFilterBTN_Click(object sender, EventArgs e)
        {
            myDataView.RowFilter = "";
            filterTB.Text = "";
        }

    }

}

