using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace SemesterDemo.Windows
{
    public partial class UserReg : Form
    {
        public UserReg()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox1.Text)|| string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("One or more of the fields is empty!");
            }
            else
            {
                if(textBox5.Text!=textBox6.Text)
                {
                    MessageBox.Show("The passwords do not match!");
                }
                else
                {
                    String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                    String sql = "insert into UserLogIn (password, name, designation, email, administration, phone) values ('" + textBox6.Text + "', '" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', 'n', '" + textBox4.Text + "')";
                    SqlConnection conn = new SqlConnection(ConnectionString);
                    SqlCommand sqlCmd = new SqlCommand(sql, conn);

                    //DataTable dt = new DataTable();

                    sqlCmd.Connection.Open();
                    sqlCmd.ExecuteNonQuery();
                    sqlCmd.Dispose();
                    //dataGridView1.DataSource = dt;
                    sqlCmd.Connection.Close();
                    conn.Close();
                    MessageBox.Show("Successfully added new user!");
                }
                /*
                
                */
            }
            /*
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("One or more of the fields is empty!");
            }
            else if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                String sql = "insert into Catalogue (item, stock, price) values ('" + textBox1.Text + "', " + textBox3.Text + "," + textBox4.Text + ")";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                //DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                //dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
                conn.Close();
                MessageBox.Show("Successfully inserted new data!");
            }
            else
            {
                String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                String sql = "insert into Catalogue (item, details, stock, price) values ('" + textBox1.Text + "', '" + textBox2.Text + "'," + textBox3.Text + "," + textBox4.Text + ")";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                //DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                //dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
                conn.Close();
                MessageBox.Show("Successfully inserted new data!");
            }
            */
        }

        private void UserReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
