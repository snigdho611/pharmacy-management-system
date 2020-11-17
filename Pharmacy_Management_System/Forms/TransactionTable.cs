using System;
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

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
