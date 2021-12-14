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
    public partial class creditpaymentform : Form
    {
        public creditpaymentform()
        {
            InitializeComponent();
        }
        public int month { get; set; }
        public int year { get; set; }
      
        

        public void button1_Click(object sender, EventArgs e)
        {
            Credit credit = new Credit();
            
            month = Convert.ToInt32(mm_txbox.Text);
            year = Convert.ToInt32(yy_txbox.Text);
            credit.ExpDate = Convert.ToString(month + " / " + year);

            credit.Cvv = Convert.ToInt32(cvv_txbox.Text);

            credit.Number = (cardno_txbox.Text);

            credit.CardName = cardname_txbox.Text;
            //MessageBox.Show(credit.Cvv + "\n" + credit.ExpDate + "\n" + credit.Number + "\n" + credit.CardName);
            MessageBox.Show("Your order will arrive in 5 work days!", "Payment Successful!");
            Form2_Order_ f2o = new Form2_Order_();
            f2o.Show();
            this.Hide();
            
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox.Checked == false)
            {
                button1.Enabled = false;
            }
            if (checkBox.Checked == true)
            {
                button1.Enabled = true;
            }
        }

        private void creditpaymentform_FormClosed(object sender, FormClosedEventArgs e)
        {
            PaymentForm pof = new PaymentForm();
            pof.Show();
        }
    }
}
