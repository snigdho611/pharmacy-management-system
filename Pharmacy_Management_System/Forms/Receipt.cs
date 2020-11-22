using System;
using System.Windows.Forms;

namespace Pharmacy_Management_System.Windows
{
    public partial class Receipt : Form
    {
        public Receipt()
        {
            InitializeComponent();

        }

        private void Receipt_Load(object sender, EventArgs e)
        {
            labelNameR.Text = CustomerDetails.nameCD;
            labelPNR.Text = CustomerDetails.PhoneNoCD;
            labelTPR.Text = CustomerUi.finalPrice;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
