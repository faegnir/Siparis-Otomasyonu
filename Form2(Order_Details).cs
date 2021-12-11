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
            Order order = new Order(orderDetail);
            Listele();
            label1.Text = "Deactive";
            label4.Text = "";

            order.Date = DateTime.Now;
            
            label17.Text = order.Date.ToString();
            order.Status = true;
            
        }
        private void Listele()
        {
            listBox1.Items.Clear();
            using (StreamReader sr = File.OpenText(Application.StartupPath + "\\Items\\items.txt"))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                    listBox1.Items.Add(str);
                }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string[] temp =listBox1.SelectedItem.ToString().Split(' ');
            
            label15.Text = orderDetail.CalcSubTotal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(temp[1])).ToString();
            label10.Text = orderDetail.CalcWeight(Convert.ToInt32(textBox1.Text),Convert.ToInt32(temp[2])).ToString();

            List<string> orders = new List<string>();

            orders.Add(temp[0]);
            foreach (var item in orders)
            {
                listBox2.Items.Add(item);
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderDetail.TaxStatus = true;
            if (orderDetail.TaxStatus == true)
                label1.Text = "Active";
        }

        private void button3_Click(object sender, EventArgs e)
        { 
            label4.Text = "Order Taken";
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            Order o = new Order(orderDetail);

            float sumTax = 0;
            float sumTotal = 0;
            string[] temp = listBox2.Items.ToString().Split(' ');
            for (int i = 0; i < temp.Length; i++)
            {
                if (i % 1 == 0)
                {
                    sumTax = o.CalcTax(Convert.ToInt32(textBox1),Convert.ToInt32(temp[i]));
                }
                if (i%2 == 0)
                {
                    
                }
            }
        }
    }
}
