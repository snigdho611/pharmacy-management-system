using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy_Management_System.Access;

namespace Pharmacy_Management_System.Windows
{
    public partial class EmployeeDetails : Form
    {
        public EmployeeDetails()
        {
            InitializeComponent();
        }

        private void EmployeeDetails_Load(object sender, EventArgs e)
        {

        }

        private DataTable dtGLobal = new DataTable();


        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            String sql = "select Id as 'ID', name as 'name', designation as 'designation', email as 'email', phone as 'phone' from admin";
            access.SqlCmd = new SqlCommand(sql, access.SqlCon);

            DataTable dt = new DataTable();
            access.SqlCmd.Connection.Open();
            dt.Load(access.SqlCmd.ExecuteReader());
            dtGLobal.Load(access.SqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            access.SqlCmd.Connection.Close();
            
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
                    DataAccess access = new DataAccess();
                    String sql = "select * from admin where id = " + Convert.ToInt32(dtGLobal.Rows[selectedRowIndex][0]) + ";";
                    access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                    DataTable dtlocal1 = new DataTable();
                    access.SqlCmd.Connection.Open();
                    dtlocal1.Load(access.SqlCmd.ExecuteReader());
                    access.SqlCmd.Connection.Close();

                    //MessageBox.Show(Convert.ToString(dt.Rows[selectedRowIndex][3]));
                    UpdatePassword UP = new UpdatePassword();
                    UP.setIDandName(Convert.ToString(dtlocal1.Rows[0][0]), Convert.ToString(dtlocal1.Rows[0][1]));
                    UP.StartPosition = FormStartPosition.CenterParent;
                    UP.ShowDialog();
                }
            }
            catch (NullReferenceException NRE)
            {
                string errorLog = NRE.ToString();
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
                    UR.StartPosition = FormStartPosition.CenterParent;


                    DataAccess access = new DataAccess();
                    String sql = "select * from admin where id = "+ Convert.ToInt32(dtGLobal.Rows[selectedRowIndex][0])+";";
                    access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                    DataTable dt2 = new DataTable();

                    access.SqlCmd.Connection.Open();
                    dt2.Load(access.SqlCmd.ExecuteReader());
                    UR.updateFrame(Convert.ToInt32(dt2.Rows[0][0]), Convert.ToString(dt2.Rows[0][1]), Convert.ToString(dt2.Rows[0][2]), Convert.ToString(dt2.Rows[0][3]), Convert.ToString(dt2.Rows[0][4]));
                    access.SqlCmd.Connection.Close();
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
                    DataAccess access = new DataAccess();
                    String sql = "delete from admin where id = " + Convert.ToInt32(dtGLobal.Rows[selectedRowIndex][0]) + ";";
                    access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                    DataTable dt2 = new DataTable();

                    access.SqlCmd.Connection.Open();
                    access.SqlCmd.ExecuteNonQuery();
                    access.SqlCmd.Connection.Close();
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
