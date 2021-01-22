using Pharmacy_Management_System.Windows;
using Pharmacy_Management_System.Access;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Pharmacy_Management_System
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
            if(string.IsNullOrWhiteSpace(txtUsername.Text)|| string.IsNullOrWhiteSpace(txtPass.Text)|| txtUsername.Text== "Enter username here" || txtPass.Text == "Enter password here")
            {
                MessageBox.Show("Please enter a valid username and password!");
            }
            else
            {
                DataAccess access = new DataAccess();
                string sql = "select * from admin where id = '" + txtUsername.Text + "'AND password = '" + txtPass.Text + "';";
                SqlCommand sqlCmd = new SqlCommand(sql, access.SqlCon);

                DataTable dt = new DataTable();

                try
                {
                    access.SqlCon.Open();
                    dt.Load(sqlCmd.ExecuteReader());
                    access.SqlCon.Close();
                }
                catch(Exception E)
                {
                    MessageBox.Show(E.ToString());
                }

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
                txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
            }

            if (String.IsNullOrWhiteSpace(txtPass.Text) == true)
            {
                txtPass.PasswordChar = '\0';
                txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70))))); ;
                txtPass.Text = "Enter password here";
            }
        }

        private void passwordFocus(object sender, EventArgs e)
        {
            if (txtPass.Text == "Enter password here")
            {
                txtPass.Text = null;
                txtPass.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
                txtPass.PasswordChar = '•';
            }

            if (String.IsNullOrWhiteSpace(txtUsername.Text) == true)
            {
                txtUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(62)))), ((int)(((byte)(70)))));
                txtUsername.Text = "Enter username here";
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                System.Diagnostics.Process.Start("https://github.com/snigdho611");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to open link that was clicked.");
            }
        }
    }
}
