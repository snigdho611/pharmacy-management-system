using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy_Management_System.Access;

namespace Pharmacy_Management_System.Windows
{
    public partial class UpdateItem : Form
    {
        public UpdateItem()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox3.Text) || string.IsNullOrWhiteSpace(textBox4.Text))
            {
                MessageBox.Show("Item, stock and price must be entered!");
            }
            else
            {
                DataAccess access = new DataAccess();
                String sql = "update catalog Set item = '" + textBox1.Text + "', details = '" + textBox2.Text + "', stock = " + textBox3.Text + ", price = " + textBox4.Text + "where id = " + CatalogueKey + ";";
                access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                access.SqlCmd.Connection.Open();
                access.SqlCmd.ExecuteNonQuery();
                access.SqlCmd.Dispose();
                access.SqlCmd.Connection.Close();
                access.SqlCon.Close();
                MessageBox.Show("Successfully Updated item details!");
                this.Dispose();
            }
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }
}
