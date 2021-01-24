using Pharmacy_Management_System.Windows;
using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy_Management_System.Access;

namespace Pharmacy_Management_System
{
    public partial class MainFrame : Form
    {
        public MainFrame()
        {
            InitializeComponent();
        }

        private void MainFrame_Load(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            access.SqlCmd = new SqlCommand("select * from catalog", access.SqlCon);
            access.SqlDA = new SqlDataAdapter(access.SqlCmd);
            DataTable table = new DataTable();
            access.SqlDA.Fill(table);
            mainGridView.DataSource = table;
            access.SqlCon.Close();
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
            if (mainGridView.CurrentCell==null)
            {
                
                MessageBox.Show("Please select an item!");
            }
            else
            {
                string selectedItem = Convert.ToString(mainGridView.SelectedRows[0].Cells[0].Value);
                DataAccess access = new DataAccess();
                String sql = "select * from catalog where id = " + selectedItem + ";";
                access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                access.SqlCmd.Connection.Open();
                dt.Load(access.SqlCmd.ExecuteReader());
                int id = Convert.ToInt32(dt.Rows[0][0]);
                string item = Convert.ToString(dt.Rows[0][1]);
                string details = Convert.ToString(dt.Rows[0][2]);
                int stock = Convert.ToInt32(dt.Rows[0][3]);
                int price = Convert.ToInt32(dt.Rows[0][4]);

                access.SqlCmd.Connection.Close();

                UpdateItem U = new UpdateItem();
                U.StartPosition = FormStartPosition.CenterScreen;
                U.setTextBoxes(id, item, details, stock, price);
                U.ShowDialog();
            }
        }

        private DataTable dt = new DataTable();
        private DataTable dtmain = new DataTable();

        //Show all products
        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess access = new DataAccess();
            String sql = "select Id as 'ID', item as 'item', details as 'details', stock as 'stock', price as 'price' from catalog";
            access.SqlCmd= new SqlCommand(sql, access.SqlCon);

            DataTable dtCatalog = new DataTable();

            access.SqlCmd.Connection.Open();
            dtCatalog.Load(access.SqlCmd.ExecuteReader());
            dtmain.Load(access.SqlCmd.ExecuteReader());
            mainGridView.DataSource = dtCatalog;
            access.SqlCmd.Connection.Close();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (mainGridView.CurrentCell == null)
            {
                MessageBox.Show("Please select a product to delete!");
            }
            else
            {
                string message = "Are you sure you want to delete this item?";
                string title = "Delete warning";
                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result = MessageBox.Show(message, title, buttons);
                if (result == DialogResult.Yes)
                {
                    DataAccess access = new DataAccess();
                    string selectedItem = Convert.ToString(mainGridView.SelectedRows[0].Cells[0].Value);
                    String sql = "delete from Catalogue where id = " + selectedItem + ";";
                    access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                    access.SqlCmd.Connection.Open();
                    access.SqlCmd.ExecuteNonQuery();
                    access.SqlCmd.Dispose();
                    access.SqlCmd.Connection.Close();
                    access.SqlCon.Close();
                    MessageBox.Show("Successfully deleted item!");
                }
                else
                {

                }
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
            EmployeeDetails ED = new EmployeeDetails();

            ED.StartPosition = FormStartPosition.CenterScreen;
            ED.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        int total = 0;
        

        private void button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (mainGridView.CurrentCell == null)
                {
                    MessageBox.Show("Please select an item to add to cart");
                }
                else
                {
                    DataGridViewRow currentSelectedRow = mainGridView.SelectedRows[0];
                    int rowCount;
                    //MessageBox.Show(cartGridView.Rows.Count.ToString());
                    cartGridView.Rows.Add();
                    rowCount = cartGridView.Rows.Count - 2;
                    cartGridView["cartId", rowCount].Value = rowCount + 1;
                    cartGridView["cartItem", rowCount].Value = currentSelectedRow.Cells[1].Value;
                    cartGridView["cartQuantity", rowCount].Value = "1";
                    cartGridView["cartPrice", rowCount].Value = currentSelectedRow.Cells[4].Value;

                    textBoxTotal.Text = Convert.ToString(Convert.ToInt32(textBoxTotal.Text)+ Convert.ToInt32(cartGridView["cartPrice", rowCount].Value));
                }
            }
            catch (NullReferenceException NRE)
            {
                MessageBox.Show("You have not selected any user!");
            }
            catch (IndexOutOfRangeException IORE)
            {
                MessageBox.Show("You must load/refresh the catalog table first!");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        public static int invoice = 0;

        private void button7_Click(object sender, EventArgs e)
        {
            int totalList = cartGridView.Rows.Count - 1;

            using (StreamWriter writer = new StreamWriter(@"D:\Snigdho\Github\Pharmacy_Management_System\Pharmacy_Management_System\Invoices\Invoice_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".txt"))
            {
                writer.WriteLine("Product     |     " + "Price      |");

                for (int i = 0; i < totalList; i++)
                {

                    writer.WriteLine(Convert.ToString(cartGridView["cartItem", i].Value) + " x " +
                        Convert.ToString(cartGridView["cartQuantity", i].Value) + "      |      " +
                        Convert.ToString(cartGridView["cartPrice", i].Value));
                }
                writer.WriteLine("Customer ID: " + textBox8.Text);
                writer.WriteLine("Total Price: " + textBoxTotal.Text);
                writer.WriteLine(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                writer.WriteLine("Billed by: " + textBox1.Text);
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            CustomerUi F = new CustomerUi();
            F.StartPosition = FormStartPosition.CenterParent;
            F.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            cartGridView.Rows.Clear();
            cartGridView.Refresh();
            textBoxTotal.Text = "0";
            total = 0;
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
            TransactionTable T = new TransactionTable();
            T.StartPosition = FormStartPosition.CenterParent;
            T.ShowDialog();
        }

        private void mainGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
