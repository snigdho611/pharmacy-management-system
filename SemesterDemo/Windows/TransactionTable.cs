using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SemesterDemo.Windows
{
    public partial class TransactionTable : Form
    {
        public TransactionTable()
        {
            InitializeComponent();
        }

        private void TransactionTable_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dB_SAFDataSet4.Transactions' table. You can move, or remove it, as needed.
            this.transactionsTableAdapter.Fill(this.dB_SAFDataSet4.Transactions);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
