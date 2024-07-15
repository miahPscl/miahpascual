using System.Data;
using System.Data.OleDb;

namespace examprac
{
    public partial class frmMain : Form
    {
        OleDbConnection conn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\JEREMIAH\\Downloads\\schoolSupplies.accdb");
        public frmMain()
        {
            InitializeComponent();
        }

        private void cboSchool_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboSchool.SelectedIndex == 0)
            {

                displayRecSubject();



            }

            else if (cboSchool.SelectedIndex == 1)
            {


                displayRecTeacher();



            }
        }

        void searchTeacher()
        {
            string query = "SELECT * FROM teacher WHERE fullname = '" + txtSearch.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdData.DataSource = dt;

        }
        void displayRecTeacher()
        {
            string query = "SELECT * from teacher order by idnumber asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdData.DataSource = dt;
        }
        void displayRecSubject()
        {
            string query = "SELECT * from subject order by code asc";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdData.DataSource = dt;
        }
        void searchSubject()
        {
            string query = "SELECT * FROM subject WHERE description = '" + txtSearch.Text + "'";
            OleDbCommand cmd = new OleDbCommand(query, conn);
            OleDbDataAdapter adapter = new OleDbDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            dgrdData.DataSource = dt;

        }

        private void btnTeacher_Click(object sender, EventArgs e)
        {
            frmTeachers teachers = new frmTeachers();
            teachers.ShowDialog();
        }

        private void btnSubject_Click(object sender, EventArgs e)
        {
            frmSubject subjects = new frmSubject();
            subjects.ShowDialog();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            cboSchool.Items.Add("Subjects");
            cboSchool.Items.Add("Teachers");


            

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (cboSchool.SelectedIndex == 0)
            {
                searchSubject();
                
                
                
            }

            else if (cboSchool.SelectedIndex == 1)
            {

                searchTeacher();
                
                
               
            }
        }
    }
}
