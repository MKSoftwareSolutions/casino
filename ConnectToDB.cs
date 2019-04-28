using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Windows.Forms;
using System.Data.OleDb;
using System.Web;

namespace WinCasino
{
    public partial class ConnectToDB : Form
    {
        static OleDbConnection conn;

        public ConnectToDB()
        {
            InitializeComponent();
        }

        public static void Connect(){

         //var DBPath = Application.StartupPath + "\\CasinoData.mdb";  
         //   conn = new OleDbConnection("provider=Microsoft.Jet.OLEDB.4.0;" + "Data Source=" + DBPath);  
         //   conn.Open();  
         //   System.Windows.Forms.MessageBox.Show("Connected successfully");

         //   DataSet myDataSet = new DataSet();
         //   var myAdapptor = new OleDbDataAdapter();
         //   OleDbCommand command = new OleDbCommand("SELECT * FROM Data", conn);
         //   myAdapptor.SelectCommand = command;
         //   myAdapptor.Fill(myDataSet, "Data");
            }
    }
}
