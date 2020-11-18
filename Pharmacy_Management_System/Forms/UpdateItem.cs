using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

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
                String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
                String sql = "update Catalogue Set item = '" + textBox1.Text + "', details = '" + textBox2.Text + "', stock = " + textBox3.Text + ", price = " + textBox4.Text + "where id = " + CatalogueKey + ";";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlCmd.Connection.Close();
                conn.Close();
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
