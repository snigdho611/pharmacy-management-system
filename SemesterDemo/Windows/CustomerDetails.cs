using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterDemo.Windows
{
    public partial class CustomerDetails : Form
    {
        public int totalList;
        public String totalItemsName;

        public CustomerDetails(int totalList, String totalItemsName)
        {
            InitializeComponent();
            this.totalList = totalList;
            this.totalItemsName = totalItemsName;
        }

        public CustomerDetails()
        {
            InitializeComponent();
        }

        private void CustomerDetails_Load(object sender, EventArgs e)
        {
            labelTPinCD.Text = Form1.finalPrice;
        }


        public static string nameCD;
        public static string PhoneNoCD;
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text) || string.IsNullOrWhiteSpace(textBoxPhoneNo.Text))
            {
                MessageBox.Show("You cannot keep Name or Phone number field empty");
            }
            else
            {
                MainFrame.invoice = MainFrame.invoice + 1;
                
                Form1 F = new Form1();
                
                //MessageBox.Show(Convert.ToString(totalList));
                string cn_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cn_connection = new SqlConnection(cn_string);
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

                String sql = "insert into Customer (Name, Email, Phone, Total) values ('" + textBoxName.Text + "','"+textBoxEmail.Text+ "','" + textBoxPhoneNo.Text + "'," + Convert.ToInt32(labelTPinCD.Text) + ");";
                SqlCommand cmd_command = new SqlCommand(sql, cn_connection);

                // cmd_command.Connection.Open();
                if (cmd_command.Connection.State != ConnectionState.Open) cmd_command.Connection.Open();
                cmd_command.ExecuteNonQuery();
                nameCD = textBoxName.Text;
                PhoneNoCD = textBoxPhoneNo.Text;
                this.invoicePrint();
                Receipt r = new Receipt();
                r.Show();

            }
        }

        public void invoicePrint()
        {
            DateTime DT;
            DT = DateTime.Now;
            //int totalList=10;
            using (StreamWriter writer = new StreamWriter(@"C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\Invoice\Invoice_" + DT.ToString("yyyyMMddHHmmss") + ".txt"))
            {
                writer.WriteLine("Product     |     " + "Price      |");

                string CNSTRING = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                string sql2 = "select top 1 cusID from Customer Order by cusID desc";
                SqlConnection conn = new SqlConnection(CNSTRING);
                SqlCommand sqlCmd2 = new SqlCommand(sql2, conn);

                DataTable dtTemp = new DataTable();

                sqlCmd2.Connection.Open();
                dtTemp.Load(sqlCmd2.ExecuteReader());
                sqlCmd2.Connection.Close();

                writer.WriteLine(totalItemsName);

                writer.WriteLine("Customer ID: " + Convert.ToString(dtTemp.Rows[0][0]));
                //writer.WriteLine("Total Price: " + r.labelTPR.Text);
                writer.WriteLine(DT.ToString("dd/MM/yyyy HH:mm:ss"));
            }
        }

        private void textBoxPhoneNo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            CustomerDetails cd = new CustomerDetails();
            this.Close();
        }
    }
}
