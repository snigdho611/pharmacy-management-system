using SemesterDemo.Windows;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SemesterDemo
{
    public partial class LogIn : Form
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(txtUsername.Text)|| string.IsNullOrWhiteSpace(txtPass.Text))
            {
                MessageBox.Show("Please enter a valid username and password!");
            }
            else
            {
                String ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=D:\\Snigdho\\Github\\Pharmacy_Management_System\\SemesterDemo\\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                string sql = "select * from admin where id = '" + txtUsername.Text + "'AND password = '" + txtPass.Text + "';";

                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                //var affectedRowCount=sqlCmd.ExecuteNonQuery();
                dt.Load(sqlCmd.ExecuteReader());

                if (dt.Rows.Count > 0)
                {
                    String adminName = Convert.ToString(dt.Rows[0][1]);
                    String verify = Convert.ToString(dt.Rows[0][5]);
                    MessageBox.Show("Welcome to the system, " + adminName + "!");
                    this.Hide();
                    MainFrame MF = new MainFrame();
                    MF.StartPosition = FormStartPosition.CenterScreen;
                    MF.admin(adminName);
                    MF.activateAdminPanel(verify);
                    MF.ShowDialog();
                    this.Close();
                }

                else if (dt.Rows.Count == 0)
                {
                    MessageBox.Show("User not found! Please try again!");
                }
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            UserReg UR = new UserReg();
            UR.StartPosition = FormStartPosition.CenterScreen;
            UR.ShowDialog();
            
        }

        private void usernameFocus(object sender, EventArgs e)
        {
            if (txtUsername.Text == "Enter username here")
            {
                txtUsername.Text = null;
                txtUsername.ForeColor = System.Drawing.Color.Black;
            }

            if (String.IsNullOrWhiteSpace(txtPass.Text) == true)
            {
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = System.Drawing.Color.DimGray;
                txtPass.Text = "Enter password here";
            }
        }

        private void passwordFocus(object sender, EventArgs e)
        {
            if (txtPass.Text == "Enter password here")
            {
                txtPass.Text = null;
                txtPass.ForeColor = System.Drawing.Color.Black;
                txtPass.PasswordChar = '•';
            }

            if (String.IsNullOrWhiteSpace(txtUsername.Text) == true)
            {
                txtUsername.ForeColor = System.Drawing.Color.DimGray;
                txtUsername.Text = "Enter username here";
            }
        }
    }
}
