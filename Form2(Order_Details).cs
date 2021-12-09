using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sipariş_Otomasyonu
{
    public partial class Form2_Order_ : Form
    {
        public Form2_Order_()
        {
            InitializeComponent();
        }
        
        OrderDetail orderDetail = new OrderDetail();
        private void Form2_Order__Load(object sender, EventArgs e)
        {
            orderDetail.TaxStatus = true;
            if (orderDetail.TaxStatus == true)
                label1.Text = "Active";
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Item item = new Item();

            
            label15.Text = orderDetail.CalcSubTotal(Convert.ToInt32(textBox1.Text),item).ToString();
            label10.Text = orderDetail.CalcWeight(Convert.ToInt32(textBox1.Text),item).ToString();
        }
    }
}
