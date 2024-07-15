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
using System.Collections;
using System.Data.OleDb;

namespace examprac
{
    public partial class frmSubject : Form
    {

        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\JEREMIAH\\Downloads\\schoolSupplies.accdb");
        public frmSubject()
        {
            InitializeComponent();
        }

        void displayRec()
        {
            string query = "SELECT * from subject order by code asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdList.DataSource = dt;
        }

        void search()
        {
            string query = "SELECT * FROM subject WHERE description = '"+txtSearch.Text+"'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdList.DataSource = dt;
        }



        private void frmSubject_Load(object sender, EventArgs e)
        {
            displayRec();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO subject(description, units) VALUES ('"+txtDescription.Text+"', '"+txtUnits.Text+"') ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE subject SET description = '"+txtDescription.Text+ "', units = '"+txtUnits.Text+ "'  WHERE code = "+txtCode.Text+" ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE * FROM subject WHERE description = '"+txtDescription.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }
    }
}
