using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterDemo.Windows
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBox5.Text)|| String.IsNullOrEmpty(textBox6.Text))
            {
                MessageBox.Show("Please enter a new password and again to confirm it!");
            }
            else if(textBox5.Text != textBox6.Text || textBox6.Text != textBox5.Text)
            {
                MessageBox.Show("The passwords do not match!");
            }
            else
            {
                String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                String sql = "update UserLogIn set password = '" + textBox6.Text + "' where id = '"+label3.Text+"'";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                //DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                //dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
                conn.Close();
                MessageBox.Show("Successfully updated password!");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
