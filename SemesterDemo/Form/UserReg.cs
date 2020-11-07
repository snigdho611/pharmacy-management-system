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
            if(textBox5.Visible == true && textBox6.Visible == true)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("One or more of the fields is empty!");
                }
                else
                {
                    if (textBox5.Text != textBox6.Text)
                    {
                        MessageBox.Show("The passwords do not match!");
                    }
                    else
                    {
                        String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                        String sql = "insert into UserLogIn (password, name, designation, email, administration, phone) values ('" + textBox6.Text + "', '" + textBox1.Text + "','" + textBox2.Text + "', '" + textBox3.Text + "', 'n', '" + textBox4.Text + "')";
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        SqlCommand sqlCmd = new SqlCommand(sql, conn);

                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Dispose();
                        sqlCmd.Connection.Close();
                        conn.Close();
                        MessageBox.Show("Successfully added new user!");
                    }
                }
            }
            else if (textBox5.Visible == false && textBox6.Visible == false)
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox2.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text) || string.IsNullOrWhiteSpace(textBox5.Text) || string.IsNullOrWhiteSpace(textBox6.Text))
                {
                    MessageBox.Show("One or more of the fields is empty!");
                }
                else
                {
                    if (textBox5.Text != textBox6.Text)
                    {
                        MessageBox.Show("The passwords do not match!");
                    }
                    else
                    {
                        String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                        String sql = "update UserLogIn set name = '"+textBox1.Text+"', designation = '"+textBox2.Text+"', email = '" + textBox3.Text +"', phone = '"+textBox4.Text+"' where id = "+privateID;
                        SqlConnection conn = new SqlConnection(ConnectionString);
                        SqlCommand sqlCmd = new SqlCommand(sql, conn);

                        sqlCmd.Connection.Open();
                        sqlCmd.ExecuteNonQuery();
                        sqlCmd.Dispose();
                        sqlCmd.Connection.Close();
                        conn.Close();
                        MessageBox.Show("Successfully updated user's info!");
                    }
                }
            }
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
