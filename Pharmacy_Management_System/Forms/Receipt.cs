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
            labelTPR.Text = Form1.finalPrice;
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
