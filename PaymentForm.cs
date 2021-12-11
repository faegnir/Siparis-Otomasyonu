using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Otomasyonu
{
    public partial class PaymentForm : Form
    {
        public PaymentForm()
        {
            InitializeComponent();
        }

        private void credit_button_Click(object sender, EventArgs e)
        {
            creditpaymentform creditpaymentform = new creditpaymentform();
            creditpaymentform.ShowDialog();
            
        }

        private void cash_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You will pay when the shipment comes.", "Order received!");
            
        }
    }
}
