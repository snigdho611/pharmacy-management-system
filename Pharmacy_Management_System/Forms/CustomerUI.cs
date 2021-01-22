using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using Pharmacy_Management_System.Access;

namespace Pharmacy_Management_System.Windows
{
    public partial class CustomerUi : Form
    {
        
        public CustomerUi()
        {
            InitializeComponent();
        }

        private void CustomerUi_Load(object sender, EventArgs e)
        {
            loadtbl_data();
            textBox_TP.Text = "0";
            label_item.Hide();

            dataGridViewCart.ReadOnly = true;
            dataGridViewItems.ReadOnly = true;

            label_ID.Hide();
            label_Stock.Hide();
            textBox_Stock.Hide();
            label_stockLeft.Hide();
            textBox_Leftstock.Hide();
            textBox_Price.Hide();
            label4.Hide();
        }
        private void loadtbl_data()
        {
            DataAccess access = new DataAccess();
            if (access.SqlCon.State != ConnectionState.Open) access.SqlCon.Open();

            string sqls = "SELECT * FROM CATALOG";

            DataTable tbl = new DataTable();
            SqlDataAdapter adapter = new SqlDataAdapter(sqls, access.SqlCon);
            adapter.Fill(tbl);

            dataGridViewItems.DataSource = tbl;


        }


        private void dataGridViewItems_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridViewItems_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow row = dataGridViewItems.Rows[index];
            label_item.Text = row.Cells[1].Value.ToString();
            label_item.Show();
            textBox_Price.Text = row.Cells[4].Value.ToString();
            textBox_Stock.Text = row.Cells[3].Value.ToString();
            label_ID.Text = row.Cells[0].Value.ToString();
            textBox1Qnt.Text = "";

        }

        private void button1A2C_Click(object sender, EventArgs e)
        {
            if (dataGridViewItems.SelectedRows.Count == 1)
            {
                if (string.IsNullOrWhiteSpace(textBox1Qnt.Text) || textBox1Qnt.Text == "0") { MessageBox.Show("Please enter a quantity"); }
                else
                {
                    int price; int quantity; int TotalPrice; int stock;
                    price = Convert.ToInt32(textBox_Price.Text);
                    quantity = Convert.ToInt32(textBox1Qnt.Text);
                    stock = Convert.ToInt32(textBox_Stock.Text);
                    TotalPrice = Convert.ToInt32(textBox_TP.Text);
                    //

                    price *= quantity;
                    TotalPrice += price;
                    //stockLeft = stockLeft - quantity;

                    if (quantity > stock) { MessageBox.Show("Not available"); }
                    else
                    {

                        stock -= quantity;
                        textBox_Stock.Text = (stock.ToString());
                        textBox_Price.Text = (price.ToString());
                        textBox_TP.Text = (TotalPrice.ToString());
                        // textBox_Leftstock.Text = (stockLeft.ToString());

                        int row;
                        dataGridViewCart.Rows.Add();
                        row = dataGridViewCart.Rows.Count - 2;
                        dataGridViewCart["Item", row].Value = label_item.Text;
                        dataGridViewCart["Quantity", row].Value = textBox1Qnt.Text;
                        dataGridViewCart["Price", row].Value = textBox_Price.Text;
                        dataGridViewCart["ID", row].Value = label_ID.Text;
                        dataGridViewCart["StockLeft", row].Value = textBox_Stock.Text;


                        int selectedRowCount = dataGridViewItems.Rows.GetRowCount(DataGridViewElementStates.Selected);
                        //int selectedRowIndex = dataGridViewItems.CurrentCell.RowIndex;

                        if (selectedRowCount > 1) { MessageBox.Show("Please select a single row"); }
                        else
                        {
                            string cn_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                            SqlConnection cn_connection = new SqlConnection(cn_string);
                            if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

                            string sql = "UPDATE Catalogue SET [Stock]='" + textBox_Stock.Text + "' WHERE Id = " + label_ID.Text;
                            SqlCommand cmd = new SqlCommand(sql, cn_connection);
                            cmd.ExecuteNonQuery();
                            loadtbl_data();
                        }
                    }
                }

            }
            else
            {
                MessageBox.Show("Please select one row to add");
            }

        }
        public static string finalPrice;

        private void buttonBuy_Click(object sender, EventArgs e)
        {
            int TotalPrice = Convert.ToInt32(textBox_TP.Text);

            if (TotalPrice > 0)
            {
                
                int totalList = dataGridViewCart.Rows.Count - 1;

                String totalItemsName = null;
                for (int i = 0; i < totalList; i++)
                {
                    totalItemsName = totalItemsName + Convert.ToString(dataGridViewCart["Item", i].Value) + " x " + Convert.ToString(dataGridViewCart["Quantity", i].Value) + "\n";
                }

                finalPrice = (TotalPrice.ToString());
                CustomerDetails cd = new CustomerDetails(totalList, totalItemsName, finalPrice);
                cd.Show();
            }
            else
            {
                MessageBox.Show("Please add something in cart to buy");
            }
            

        }

        private void textBox1Qnt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar)) { }
            else
            {
                e.Handled = e.KeyChar != (char)Keys.Back;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int selectedRowCount = dataGridViewCart.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                int rowDelete = dataGridViewCart.CurrentCell.RowIndex;
                dataGridViewCart.Rows.RemoveAt(rowDelete);

                int stockLeft; int stockd;
                stockLeft = Convert.ToInt32(textBox_Leftstock.Text);
                stockd = Convert.ToInt32(textBox_Stock.Text);
                stockLeft += stockd;
                textBox_Leftstock.Text = stockLeft.ToString();

                int tp = Convert.ToInt32(textBox_TP.Text);
                int price = Convert.ToInt32(textBox_Price.Text);
                tp -= price;
                textBox_TP.Text = (tp.ToString());

                string cn_string = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\LENOVO\source\repos\SemesterDemo\SemesterDemo\DB_SAF.mdf;Integrated Security=True;Connect Timeout=30";
                SqlConnection cn_connection = new SqlConnection(cn_string);
                if (cn_connection.State != ConnectionState.Open) cn_connection.Open();

                string sql = "UPDATE Catalogue SET [Stock]=+'" + textBox_Leftstock.Text + "' WHERE Id = " + label_ID.Text;
                SqlCommand cmd = new SqlCommand(sql, cn_connection);
                cmd.ExecuteNonQuery();
                loadtbl_data();

            }
            else
            {
                MessageBox.Show("Select a whole row in cart to delete");
            }


        }

        private void dataGridViewCart_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                int index1 = e.RowIndex;
                DataGridViewRow row1 = dataGridViewCart.Rows[index1];

                int selectedRowCount = dataGridViewCart.Rows.GetRowCount(DataGridViewElementStates.Selected);

                textBox_Price.Text = row1.Cells[2].Value.ToString();
                textBox_Stock.Text = row1.Cells[1].Value.ToString();
                textBox_Leftstock.Text = row1.Cells[4].Value.ToString();
                label_ID.Text = row1.Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("No product in this row");
            }

        }

        private void dataGridViewCart_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
