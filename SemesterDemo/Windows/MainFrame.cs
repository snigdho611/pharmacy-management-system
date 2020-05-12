using SemesterDemo.Windows;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterDemo
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SAFDataSet.Catalogue' table. You can move, or remove it, as needed.
            this.catalogueTableAdapter.Fill(this.dB_SAFDataSet.Catalogue);
        }

        private void AddItem_Click(object sender, EventArgs e)
        {
            NewItem A = new NewItem();
            A.StartPosition = FormStartPosition.CenterScreen;
            A.ShowDialog();
        }

        //Enter a product key and a new frame will pop up with all of it's specific product details
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid product ID for updating!");
            }
            else
            {
                String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
                String sql = "select * from Catalogue where id = " + textBox2.Text + ";";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                DataTable dt = new DataTable();

                sqlCmd.Connection.Open();
                dt.Load(sqlCmd.ExecuteReader());
                int id = Convert.ToInt32(dt.Rows[0][0]);
                string item = Convert.ToString(dt.Rows[0][1]);
                string details = Convert.ToString(dt.Rows[0][2]);
                int stock = Convert.ToInt32(dt.Rows[0][3]);
                int price = Convert.ToInt32(dt.Rows[0][4]);

                sqlCmd.Connection.Close();

                UpdateItem U = new UpdateItem();
                U.StartPosition = FormStartPosition.CenterScreen;
                U.setTextBoxes(id, item, details, stock, price);
                U.ShowDialog();
            }
        }

        //Show all products
        private void button1_Click(object sender, EventArgs e)
        {
            String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
            String sql = "select Id as 'ID', item as 'item', details as 'details', stock as 'stock', price as 'price' from Catalogue";
            SqlConnection conn = new SqlConnection(ConnectionString);
            SqlCommand sqlCmd = new SqlCommand(sql, conn);

            DataTable dt = new DataTable();

            sqlCmd.Connection.Open();
            dt.Load(sqlCmd.ExecuteReader());
            dataGridView1.DataSource = dt;
            sqlCmd.Connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid product ID to delete!");
            }
            else
            {
                String ConnectionString = "Data Source = (LocalDB)\\MSSQLLocalDB; AttachDbFilename = C:\\Users\\LENOVO\\source\\repos\\SemesterDemo\\SemesterDemo\\DB_SAF.mdf; Integrated Security = True; Connect Timeout = 30";
                String sql = "delete from Catalogue where id = "+ textBox2.Text + ";";
                SqlConnection conn = new SqlConnection(ConnectionString);
                SqlCommand sqlCmd = new SqlCommand(sql, conn);

                DataTable dt = new DataTable();
                sqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                //dataGridView1.DataSource = dt;
                sqlCmd.Connection.Close();
                conn.Close();
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            string message = "Are you sure you want to log out?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Hide();
                LogIn L = new LogIn();
                L.ShowDialog();
                this.Close();
            }
            else
            {
                 
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
    }
}
