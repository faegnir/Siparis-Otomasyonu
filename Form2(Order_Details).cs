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
        float sumTax = 0;
        float sumTotal = 0;
        float sumWeight = 0;
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
            Order o = new Order(orderDetail);
            if (textBox1.Text == "")
            {
                MessageBox.Show("Please provide quantity!");


            }
            else
            {

                string[] temp = listBox1.SelectedItem.ToString().Split(' ');

                label15.Text = orderDetail.CalcSubTotal(Convert.ToInt32(textBox1.Text), Convert.ToInt32(temp[1])).ToString();
                label10.Text = orderDetail.CalcWeight(Convert.ToInt32(textBox1.Text), Convert.ToInt32(temp[2])).ToString();


                SepeteEkle(temp[0]);

                Hesapla(float.Parse(temp[1]), Convert.ToInt32(temp[2]));

                label3.Text = sumTax.ToString();
                label9.Text = sumTotal.ToString();
                label11.Text = sumWeight.ToString();
            }
        }
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            orderDetail.TaxStatus = true;
            if (orderDetail.TaxStatus == true)
                label1.Text = "Active";
        }

        private void SepeteEkle(string name)
        {
            //Sepete ürünlerin isimlerini ekledik
            List<string> orders = new List<string>();

            orders.Add(name);
            foreach (var item in orders)
            {
                listBox2.Items.Add(item);
            }
        }

        private void Hesapla(float price,int weight)
        {
            Order o = new Order(orderDetail);
            //sepetteki ürünlerin ağırlığı kdv'si ve toplam ücretini hesapladık

            sumTax += o.CalcTax(Convert.ToInt32(textBox1.Text), price);
            sumTotal += o.CalcTotal(Convert.ToInt32(textBox1.Text), price);
            sumWeight += o.CalcTotalWeight(Convert.ToInt32(textBox1.Text), weight);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            using (StreamWriter sw = File.AppendText(Application.StartupPath + "\\Items\\orders.txt"))//her item için ayrı dosya
            {
                foreach (var aq in listBox2.Items)
                {
                    sw.Write(aq.ToString() + " "); 
                }
                sw.Write(label9.Text);
                sw.Close();
            }
            PaymentForm pf = new PaymentForm();
            pf.Show();
            this.Hide();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            
            if (checkBox1.Checked == true)
            {
                 Form2_Order_ fu = new Form2_Order_();
                 fu.Show();
                fu.Location = this.Location;
                 this.Hide();
             
            }
        }

    }
}
