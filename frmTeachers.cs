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
    public partial class frmTeachers : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\JEREMIAH\\Downloads\\schoolSupplies.accdb");
        public frmTeachers()
        {
            InitializeComponent();
        }

        void displayRec()
        {
            string query = "SELECT * from teacher order by idnumber asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdList.DataSource = dt;
        }

        void search()
        {
            string query = "SELECT * FROM teacher WHERE fullname = '"+txtSearch.Text+"'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdList.DataSource = dt;

        }


        private void btnAdd_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO teacher(fullname, email, sex) VALUES ('"+txtFullname.Text+ "', '"+txtEmail.Text+"', '"+txtSex.Text+"') ";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE teacher SET fullname  = '"+txtFullname.Text+ "', email  = '"+txtEmail.Text+"', sex  = '"+txtSex.Text+"' WHERE idnumber = "+txtID.Text+"";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            conn.Open();
            OleDbCommand cmd = new OleDbCommand();
            cmd.Connection = conn;
            cmd.CommandText = "DELETE * FROM teacher WHERE fullname = '"+txtFullname.Text+"'";
            cmd.ExecuteNonQuery();
            conn.Close();
            displayRec();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
        }

        private void frmTeachers_Load(object sender, EventArgs e)
        {
            displayRec();
        }
    }
}
