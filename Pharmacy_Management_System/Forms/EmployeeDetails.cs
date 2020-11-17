using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SemesterDemo.Windows
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SAFDataSet3.UserLogIn' table. You can move, or remove it, as needed.

        }

        private DataTable dtGLobal = new DataTable();


        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
            String sql = "select Id as 'ID', name as 'name', designation as 'designation', email as 'email', phone as 'phone' from UserLogIn";
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();
            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dtGLobal.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                Int32 selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("You have selected multiple rows. Please select a single row!");
                }
                else
                {
                    String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
                    String sql = "select * from UserLogIn where id = " + Convert.ToInt32(dtGLobal.Rows[selectedRowIndex][0]) + ";";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    SqlCommand sqlCmd = new SqlCommand(sql, conn);
                    


                    DataTable dtlocal1 = new DataTable();
                    sqlCmd.Connection.Open();
                    dtlocal1.Load(sqlCmd.ExecuteReader());
                    sqlCmd.Connection.Close();

                    //MessageBox.Show(Convert.ToString(dt.Rows[selectedRowIndex][3]));
                    UpdatePassword UP = new UpdatePassword();
                    UP.setIDandName(Convert.ToString(dtlocal1.Rows[0][0]), Convert.ToString(dtlocal1.Rows[0][1]));
                    UP.StartPosition = FormStartPosition.CenterParent;
                    UP.ShowDialog();
                }
            }
            catch (NullReferenceException NRE)
            {
                MessageBox.Show("You have not selected any user!");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                Int32 selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("You have selected multiple rows. Please select a single row!");
                }
                else
                {
                    UserReg UR = new UserReg();
                    //UR.updateFrame();
                    UR.StartPosition = FormStartPosition.CenterParent;
                    

                    String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
                    String sql = "select * from UserLogIn where id = "+ Convert.ToInt32(dtGLobal.Rows[selectedRowIndex][0])+";";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    SqlCommand sqlCmd = new SqlCommand(sql, conn);

                    DataTable dt2 = new DataTable();

                    sqlCmd.Connection.Open();
                    dt2.Load(sqlCmd.ExecuteReader());
                    //dataGridView1.DataSource = dt;
                    UR.updateFrame(Convert.ToInt32(dt2.Rows[0][0]), Convert.ToString(dt2.Rows[0][1]), Convert.ToString(dt2.Rows[0][2]), Convert.ToString(dt2.Rows[0][3]), Convert.ToString(dt2.Rows[0][4]));
                    sqlCmd.Connection.Close();
                    UR.ShowDialog();
                }
            }
            catch (NullReferenceException NRE)
            {
                MessageBox.Show("You have not selected any user!");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            UserReg UR = new UserReg();
            UR.normalFrame();
            UR.StartPosition = FormStartPosition.CenterScreen;
            UR.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                Int32 selectedRowCount = dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
                Int32 selectedRowIndex = dataGridView1.CurrentCell.RowIndex;
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("You have selected multiple rows. Please select a single row!");
                }
                else
                {
                    String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
                    String sql = "delete from UserLogIn where id = " + Convert.ToInt32(dtGLobal.Rows[selectedRowIndex][0]) + ";";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    SqlCommand sqlCmd = new SqlCommand(sql, conn);

                    DataTable dt2 = new DataTable();

                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    //dataGridView1.DataSource = dt;
                    sqlCmd.Connection.Close();
                    MessageBox.Show("Successfully deleted selected data!");
                }
            }
            catch (NullReferenceException NRE)
            {
                MessageBox.Show("You have not selected any user!");
            }
        }
    }
}
