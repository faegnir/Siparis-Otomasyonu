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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
   
        private void addItem_Click(object sender, EventArgs e)
        {
            Item item = new Item();
            OrderDetail orderDetail = new OrderDetail();

            item.GetPriceForQuantity(Convert.ToInt32(textBox2.Text));
            item.GetWeight(Convert.ToInt32(textBox1.Text));
            item.Description = richTextBox1.Text;

            orderDetail.AddItem(item.Description, item.Price, item.ShippingWeight);

            //dosyaya yaz
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\Items\\items.txt"))//her item için ayrı dosya
            {
                sw.WriteLine(item.Description + " " + item.Price + " " + item.ShippingWeight);
                sw.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Bizi order details menüsüne götürür
            Form2_Order_ orderDetailsMenu = new Form2_Order_();
            orderDetailsMenu.ShowDialog();
        }
    }
}
