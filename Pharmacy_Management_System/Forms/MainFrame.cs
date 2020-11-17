using SemesterDemo.Windows;
using System;
using System.IO;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using SemesterDemo.Access;

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
            DataAccess access = new DataAccess();
            access.SqlCmd = new SqlCommand("select * from catalog", access.SqlCon);
            access.SqlDA = new SqlDataAdapter(access.SqlCmd);
            DataTable table = new DataTable();
            access.SqlDA.Fill(table);
            mainGridView.DataSource = table;
            
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
                DataAccess access = new DataAccess();
                String sql = "select * from Catalogue where id = " + textBox2.Text + ";";
                SqlCommand sqlCmd = new SqlCommand(sql, access.SqlCon);

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
            if (string.IsNullOrWhiteSpace(textBox2.Text))
            {
                MessageBox.Show("Please enter a valid product ID to delete!");
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
                    String sql = "delete from Catalogue where id = " + textBox2.Text + ";";
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
                Int32 selectedRowCount = mainGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
                Int32 selectedRowIndex = mainGridView.CurrentCell.RowIndex;
                if (selectedRowCount > 1)
                {
                    MessageBox.Show("You have selected multiple rows. Please select a single item!");
                }
                else
                {

                    DataAccess access = new DataAccess();
                    String sql = "select * from catalog where id = " + Convert.ToInt32(dtmain.Rows[selectedRowIndex][0]) + ";";
                    access.SqlCmd = new SqlCommand(sql, access.SqlCon);

                    DataTable dtCustomer = new DataTable();
                    access.SqlCmd.Connection.Open();
                    dtCustomer.Load(access.SqlCmd.ExecuteReader());


                    access.SqlCmd.Connection.Close();
                    int row = 0;
                    try
                    {
                        total = total + Convert.ToInt32(dtCustomer.Rows[0][4]) * (Convert.ToInt32(textBox3.Text));
                        dataGridView2.Rows.Add();
                        row = dataGridView2.Rows.Count - 2;
                        dataGridView2["Column1", row].Value = dtCustomer.Rows[0][0];
                        dataGridView2["Column2", row].Value = dtCustomer.Rows[0][1];
                        dataGridView2["Column3", row].Value = textBox3.Text;
                        dataGridView2["Column4", row].Value = Convert.ToInt32(dtCustomer.Rows[0][4]) * (Convert.ToInt32(textBox3.Text));
                        textBox4.Text = Convert.ToString(total);
                    }
                    catch (FormatException FE)
                    {
                        MessageBox.Show("Please enter a numerical value");
                    }
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
            invoice = invoice + 1;
            total = 0;
            DateTime DT;
            DT = DateTime.Now;
            int totalList = dataGridView2.Rows.Count-1;
            if (Convert.ToInt32(totalList) <= 0)
            {
                MessageBox.Show("You didn't select products!");

            }
            else if ((String.IsNullOrWhiteSpace(textBox5.Text) == true || String.IsNullOrWhiteSpace(textBox6.Text) == true || String.IsNullOrWhiteSpace(textBox7.Text) == true) && String.IsNullOrWhiteSpace(textBox8.Text) == true)
            {
                String totalItemsName = null;
                for (int i = 0; i <= totalList; i++)
                {
                    totalItemsName = totalItemsName + Convert.ToString(dataGridView2["Column2", i].Value) + "x" + Convert.ToString(dataGridView2["Column3", i].Value) + " ";
                }

                DataAccess access = new DataAccess();
                string sql = "insert into Transactions (items, total, datetime) values ('" + totalItemsName + "', " + textBox4.Text + ", GETDATE())";
                SqlCommand sqlCmd = new SqlCommand(sql, access.SqlCon);

                access.SqlCmd.Connection.Open();
                sqlCmd.ExecuteNonQuery();
                sqlCmd.Dispose();
                sqlCmd.Connection.Close();
                access.SqlCmd.Connection.Close();
                MessageBox.Show("Successfully inserted new transaction!");
                //this.Dispose();

                using (StreamWriter writer = new StreamWriter(@"C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\Invoice\Invoice_" + DT.ToString("yyyyMMddHHmmss") + ".txt"))
                {
                    writer.WriteLine("Product     |     " + "Price      |");

                    for (int i = 0; i < totalList; i++)
                    {

                        writer.WriteLine(Convert.ToString(dataGridView2["Column2", i].Value) + " x " +
                            Convert.ToString(dataGridView2["Column3", i].Value) + "      |      " +
                            Convert.ToString(dataGridView2["Column4", i].Value));
                    }
                    writer.WriteLine("Customer ID: " + textBox8.Text);
                    writer.WriteLine("Total Price: " + textBox4.Text);
                    writer.WriteLine(DT.ToString("dd/MM/yyyy HH:mm:ss"));
                    writer.WriteLine("Billed by: " + textBox1.Text);
                }


            }

            else if ((String.IsNullOrWhiteSpace(textBox5.Text) == true || String.IsNullOrWhiteSpace(textBox6.Text) == true || String.IsNullOrWhiteSpace(textBox7.Text) == true) && String.IsNullOrWhiteSpace(textBox8.Text) == false)
            {
                String totalItemsName = null;
                for (int i = 0; i <= totalList; i++)
                {
                    totalItemsName = totalItemsName + Convert.ToString(dataGridView2["Column2", i].Value) + "x" + Convert.ToString(dataGridView2["Column3", i].Value) + " ";
                }

                DataAccess access = new DataAccess();
                string sql = "select * from Customer where cusid = " + textBox8.Text;

                SqlCommand sqlCmd = new SqlCommand(sql, access.SqlCon);

                DataTable dtTemp = new DataTable();

                access.SqlCmd.Connection.Open();
                dtTemp.Load(sqlCmd.ExecuteReader());

                if (dtTemp.Rows.Count > 0)
                {
                    string sql2 = "insert into Transactions (cusID, items, total, datetime) values (" + textBox8.Text + ",'" + totalItemsName + "', " + textBox4.Text + ", GETDATE())";
                    SqlCommand sqlCmd2 = new SqlCommand(sql2, access.SqlCon);

                    sqlCmd2.Connection.Open();
                    sqlCmd2.ExecuteNonQuery();
                    sqlCmd2.Dispose();
                    sqlCmd2.Connection.Close();
                    access.SqlCmd.Connection.Close();
                    MessageBox.Show("Successfully inserted new transaction!");

                    using (StreamWriter writer = new StreamWriter(@"C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\Invoice\Invoice_" + DT.ToString("yyyyMMddHHmmss") + ".txt"))
                    {
                        writer.WriteLine("Product     |     " + "Price      |");

                        for (int i = 0; i <= totalList; i++)
                        {

                            writer.WriteLine(Convert.ToString(dataGridView2["Column2", i].Value) + " x " +
                                Convert.ToString(dataGridView2["Column3", i].Value) + "      |      " +
                                Convert.ToString(dataGridView2["Column4", i].Value));
                        }
                        writer.WriteLine("Customer ID: " + textBox8.Text);
                        writer.WriteLine("Total Price: " + textBox4.Text);
                        writer.WriteLine(DT.ToString("dd/MM/yyyy HH:mm:ss"));
                        writer.WriteLine("Billed by: " + textBox1.Text);

                    }
                }
                else if (dtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("Customer ID unavailable");
                }
            }
            //If a new customer wants to enroll with their name, mail and phone
            else if ((String.IsNullOrWhiteSpace(textBox5.Text) == false || String.IsNullOrWhiteSpace(textBox6.Text) == false || String.IsNullOrWhiteSpace(textBox7.Text) == false) && String.IsNullOrWhiteSpace(textBox8.Text) == true)
            {
                String totalItemsName = null;
                for (int i = 0; i <= totalList; i++)
                {
                    totalItemsName = totalItemsName + Convert.ToString(dataGridView2["Column2", i].Value) + "x" + Convert.ToString(dataGridView2["Column3", i].Value) + " ";
                }

                MessageBox.Show("Added Customer");

                DataAccess access = new DataAccess();
                string sql = "insert into Customer (name, email, phone, total) values('"+textBox5.Text+"','"+textBox6.Text+"','"+textBox7.Text+"',"+textBox4.Text+")";
                string sql2 = "select top 1 cusID from Customer Order by cusID desc";
                SqlCommand sqlCmd = new SqlCommand(sql, access.SqlCon);
                SqlCommand sqlCmd2 = new SqlCommand(sql2, access.SqlCon);

                DataTable dtTemp = new DataTable();

                access.SqlCmd.Connection.Open();
                access.SqlCmd.ExecuteNonQuery();
                dtTemp.Load(sqlCmd2.ExecuteReader());
                access.SqlCmd.Connection.Close();

                if (dtTemp.Rows.Count > 0)
                {
                    string sql3 = "insert into Transactions (cusID, items, total, datetime) values (" + Convert.ToInt32(dtTemp.Rows[0][0]) + ",'" + totalItemsName + "', " + textBox4.Text + ", GETDATE())";
                    access.SqlCmd = new SqlCommand(sql3, access.SqlCon);

                    access.SqlCmd.Connection.Open();
                    access.SqlCmd.ExecuteNonQuery();
                    access.SqlCmd.Dispose();
                    access.SqlCmd.Connection.Close();
                    MessageBox.Show("Successfully inserted new transaction!");

                    using (StreamWriter writer = new StreamWriter(@"C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\Invoice\Invoice_" + DT.ToString("yyyyMMddHHmmss") + ".txt"))
                    {
                        writer.WriteLine("Product     |     " + "Price      |");

                        for (int i = 0; i <= totalList; i++)
                        {

                            writer.WriteLine(Convert.ToString(dataGridView2["Column2", i].Value) + " x " +
                                Convert.ToString(dataGridView2["Column3", i].Value) + "      |      " +
                                Convert.ToString(dataGridView2["Column4", i].Value));
                        }
                        writer.WriteLine("Customer ID: " + textBox8.Text);
                        writer.WriteLine("Total Price: " + textBox4.Text);
                        writer.WriteLine(DT.ToString("dd/MM/yyyy HH:mm:ss"));
                        writer.WriteLine("Billed by: " + textBox1.Text);

                    }
                }
            }
            else if ((String.IsNullOrWhiteSpace(textBox5.Text) == false || String.IsNullOrWhiteSpace(textBox6.Text) == false || String.IsNullOrWhiteSpace(textBox7.Text) == false) && String.IsNullOrWhiteSpace(textBox8.Text) == false)
            {
                MessageBox.Show("Invalid, remove Customer ID field for new user!");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form1 F = new Form1();
            F.StartPosition = FormStartPosition.CenterParent;
            F.ShowDialog();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            dataGridView2.Rows.Clear();
            dataGridView2.Refresh();
            textBox4.Text = "0";
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
