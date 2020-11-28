using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy_Management_System.Access;

namespace Pharmacy_Management_System.Windows
{
    public partial class UpdatePassword : Form
    {
        public UpdatePassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(String.IsNullOrEmpty(textBoxPassword.Text)|| String.IsNullOrEmpty(textBoxPasswordConfirm.Text))
            {
                MessageBox.Show("Please enter a new password and again to confirm it!");
            }
            else if(textBoxPassword.Text != textBoxPasswordConfirm.Text || textBoxPasswordConfirm.Text != textBoxPassword.Text)
            {
                MessageBox.Show("The passwords do not match!");
            }
            else
            {
                DataAccess access = new DataAccess();
                String sql = "update UserLogIn set password = '" + textBoxPasswordConfirm.Text + "' where id = '"+label3.Text+"'";
                access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                //DataTable dt = new DataTable();

                access.SqlCmd.Connection.Open();
                access.SqlCmd.ExecuteNonQuery();
                access.SqlCmd.Dispose();
                access.SqlCmd.Connection.Close();
                access.SqlCon.Close();
                MessageBox.Show("Successfully updated password!");
            }
                
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
