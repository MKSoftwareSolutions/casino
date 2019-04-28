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
using System.IO;
using ShockwaveFlashObjects;
using System.Xml;
using AxShockwaveFlashObjects;

namespace WinCasino
{

    public partial class work : Form
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


        public work()
        {
            InitializeComponent();

            var DBPath = "C:\\Data\\CasinoData.mdb";//Application.StartupPath + 
            connString = "provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath;
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


        private void clear_filter(object sender, EventArgs e)
        {
            myDataView.RowFilter = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string mystr;
            addCustomerBTN.Visible = true;


            try
            {
                using (var obj = new work())
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

        private void button2_Click(object sender, EventArgs e)
        {
            {
                myDataView.RowFilter = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

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

        private void addCustomerBTN_Click(object sender, EventArgs e)
        {
            // customerSideMenuButtonChanged();
            findCustomerGB.Visible = false;
            addCustomerGB.Visible = true;
        }

        private void findCustomerBTN_Click(object sender, EventArgs e)
        {
            // customerSideMenuButtonChanged();
            findCustomerGB.Visible = true;
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
                using (var obj = new work())
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


      

   




protected string getCode()
    {
        Guid g = Guid.NewGuid();
        PassKey = g.ToString();
        return PassKey;
    }


    

    private void generateCodeBTN_Click(object sender, EventArgs e)
    {
        Code = getCode();

        if (LookingForNewCode == "1")
        {
            getCodeNewCodeTB.Text = Code;
            UnKey = getCodeFirstNameTB.Text + getCodeSSNTB.Text;

        }
    }

        //protected void GridView1_DataBound(object sender, EventArgs e)
        //{
        //    int rowCount = GridView1.Rows.Count;

        //    if (rowCount >= 1)
        //    {
        //        userCount = 1;
        //        Label1.Text = "Customer Found";
        //    }
        //    else
        //    {
        //        Label1.Text = "Customer Not Found";
        //    }
        //}

        //protected void SearchButton_Click1(object sender, EventArgs e)
        //{

        //    UnKeyTextBox1.Text = FirstNameTextBox1.Text + SSNTextBox1.Text;

        //    UnKey = UnKeyTextBox1.Text;
        //    GridView1.DataBind(); // fires databound method


        //    if (userCount == 1) // user found - just add deposit from gui and data from dt in checkifcustomerexists() 
        //    {
        //        SaveDepositButton.Visible = true;
        //    }
        //    else
        //    { // not found - need to add new customer
        //        Panel1.Visible = false;
        //        SearchButton.Visible = false;
        //        Panel2.Visible = true;
        //        SaveDepositButton.Visible = false;
        //        SaveCustomerButton.Visible = true;
        //        FirstNameTextBox2.Text = FirstNameTextBox1.Text;
        //        SSNTextBox2.Text = SSNTextBox1.Text;
        //        UnKeyTextBox2.Text = UnKeyTextBox1.Text;
        //        SaveCustomerButton.Visible = true;
        //    }

        //}


        //protected void SaveDepositButton_Click(object sender, EventArgs e)
        //{
        //    int DepositIndex = 3;
        //    int BalanceIndex = 4;
        //   // int CodeIndex = 5; 
        //    int UsedIndex = 6;
        //    int MachineIndex = 7;
        //    foreach (GridViewRow row in GridView1.Rows)  // why is this in a loop? wtf is it?
        //    {
        //        row.Cells[DepositIndex].Text = DepositTextBox1.Text;
        //        int DepositToInt = Convert.ToInt32(DepositTextBox1.Text);
        //        int BalanceToInt = Convert.ToInt32(row.Cells[BalanceIndex].Text);
        //        int NewBalance = BalanceToInt + DepositToInt;
        //        row.Cells[BalanceIndex].Text = NewBalance.ToString();

        //        row.Cells[UsedIndex].Text = "No";
        //        row.Cells[MachineIndex].Text = "None";
        //    }

        //    updateMainGrid();

        //}

        //protected void updateMainGrid()
        //{

        //    unkey = FirstNameTextBox1.Text + SSNTextBox1.Text;
        //    int UnKeyIndex = 2;
        //    int DepositIndex = 3;
        //    int BalanceIndex = 4;
        //    int CodeIndex = 5;
        //    int UsedIndex = 6;
        //    int MachineIndex = 7;
        //    //Label1.Text = unkey;

        //    foreach (GridViewRow row2 in GridView2.Rows)
        //    {
        //        if (row2.Cells[UnKeyIndex].Text == unkey)
        //        {
        //            row2.Cells[DepositIndex].Text = DepositTextBox1.Text;
        //            int DepositToInt = Convert.ToInt32(DepositTextBox1.Text);
        //            int BalanceToInt = Convert.ToInt32(row2.Cells[BalanceIndex].Text);
        //            int NewBalance = BalanceToInt + DepositToInt;
        //            string newCode = new string(getCode().Take(8).ToArray());  // assign new access code
        //            row2.Cells[BalanceIndex].Text = NewBalance.ToString();
        //            row2.Cells[CodeIndex].Text = newCode;  // assign new access code
        //            row2.Cells[UsedIndex].Text = "No";
        //            row2.Cells[MachineIndex].Text = "None";
        //            SQLUpdate(DepositTextBox1.Text, NewBalance.ToString(), unkey, newCode);
        //         }
        //    }
        //}

        //protected void Button1_Click(object sender, EventArgs e)
        //{
        //    Response.Redirect("Cashier.aspx");
        //}


        //protected void SQLUpdate(string dep, string bal, string unk, string newAccCde)// when customer found just adding new deposit info
        //{
        //    Deposit = dep;
        //    Balance = bal;
        //    UnKey = unk;
        //    Code = newAccCde;

        //    // private static

        //    string connString = ConfigurationManager.ConnectionStrings["ConnectionForGV2"].ConnectionString;
        //    System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(connString);

        //    con.Open();
        //    string cmdStr = "UPDATE Data SET Deposit = '" + Deposit + "', Balance = '" + Balance + "', Code = '" + Code + "' WHERE UnKey = '" + UnKey + "'";
        //    OleDbCommand cmd = new OleDbCommand(cmdStr, con);
        //    cmd.CommandType = CommandType.Text;
        //    cmd.Parameters.AddWithValue(@Deposit, Deposit);
        //    cmd.Parameters.AddWithValue(@Balance, Balance);
        //    cmd.Parameters.AddWithValue(@Code, Code);
        //    cmd.Parameters.AddWithValue("?", UnKey);
        //    cmd.ExecuteNonQuery();
        //    con.Close();

        //    // SqlDataAdapter ad = new SqlDataAdapter();
        //}

        //protected void SQLInsert(string fn, string ssn, string unk, string dep, string bal, string cde, string usd, string mchn, string dte)// when customer found just adding new deposit info
        //{
        //    FirstName = fn;
        //    SSN = ssn;
        //    UnKey = unk;
        //    Deposit = dep;
        //    Balance = dep;
        //    Code = cde;
        //    Used = usd;
        //    Machine = mchn;
        //    DateS = dte;

        //    // private static

        //    string connString = ConfigurationManager.ConnectionStrings["ConnectionForGV2"].ConnectionString;
        //    System.Data.OleDb.OleDbConnection con = new System.Data.OleDb.OleDbConnection(connString);


        //    OleDbCommand insert = new OleDbCommand();
        //    insert.CommandType = CommandType.Text;
        //    insert.CommandText = "INSERT INTO Data ([FirstName], [SSN], [UnKey], [Deposit], [Balance], [Code], [Used], [Machine], [DateS]) " + "VALUES (@FirstName,@SSN,@Unkey,@Deposit,@Balance,@Code,@Used,@Machine,@DateS)";
        //    insert.Parameters.AddWithValue("@FirstName", FirstName);
        //    insert.Parameters.AddWithValue("@SSN", SSN);
        //    insert.Parameters.AddWithValue("@UnKey", UnKey);
        //    insert.Parameters.AddWithValue("@Deposit", Deposit);
        //    insert.Parameters.AddWithValue("@Balance", Balance);
        //    insert.Parameters.AddWithValue("@Code", Code);
        //    insert.Parameters.AddWithValue("@Used", Used);
        //    insert.Parameters.AddWithValue("@Machine", Machine);
        //    insert.Parameters.AddWithValue("@DateS", DateS);
        //    insert.Connection = con;
        //    con.Open();
        //    insert.ExecuteNonQuery();
        //    con.Close();
        //    provideFlashData(FirstName, SSN, UnKey, Deposit, Balance, Code, Used, Machine, DateS); /////////////////////////////////////create and write to file to be read by flash

        //}
        //public void provideFlashData(string fn, string ssn, string unk, string dep, string bal, string cde, string usd, string mchn, string dte)
        //{ /////////////////////////////////////create and write to file to be read by flash
        //    var folder = "C:/User_Data/" + Code + "");
        //    if (!Directory.Exists(folder))
        //    {
        //        Directory.CreateDirectory(folder);

        //    }
        //    else
        //    {
        //        var theFilePath = folder + "/flashdata.txt";
        //        if (File.Exists(theFilePath))
        //        {
        //            File.Delete(theFilePath);
        //        }
        //       // this is only going to work if our retrieval of the data only retrieves/stores the last entry. 
        //        // this will need to be thoroughly tested because it may just pick up first entry
        //    }

        //    // game controller should already bwe loaded
        //    // this IS a good time to disable code tectfield if the entry/access/code was good

        //    writeData();
        //}

        //void writeData()
        //{
        //    using (StreamWriter _testData = new StreamWriter(Server.MapPath("~/User_Data/" + Code + "/flashdata.txt"), true))
        //    {
        //        _testData.WriteLine(FirstName);
        //        _testData.WriteLine(SSN);
        //        _testData.WriteLine(UnKey);
        //        _testData.WriteLine(Deposit);
        //        _testData.WriteLine(Balance);
        //        _testData.WriteLine(Code);
        //        _testData.WriteLine(Used);
        //        _testData.WriteLine(Machine);
        //        _testData.WriteLine(DateS);

        //    }
        //}

    //protected void SaveCustomerButton_Click(object sender, EventArgs e)
    //{
    //    string fn = FirstNameTextBox2.Text;
    //    string ssn = SSNTextBox2.Text;
    //    string unk = fn + ssn;
    //    string dep = DepositTextBox2.Text;
    //    string bal = dep;
    //    string cde = new string(getCode().Take(8).ToArray());
    //    string usd = "No";
    //    string mchn = "None";
    //    string dte = DateTime.Now.ToString();


    //    SQLInsert(fn, ssn, unk, dep, bal, cde, usd, mchn, dte);
    //    provideFlashData(fn, ssn, unk, dep, bal, cde, usd, mchn, dte);
    //}









    }

}

























