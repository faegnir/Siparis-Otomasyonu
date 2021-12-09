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
        
        private void Form2_Order__Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(Application.StartupPath + "\\Items\\items.txt"))
            {
                string str = "";
                int sayac = 0;
                while ((str = sr.ReadLine()) != null) 
                {
                    foreach (var i in str.Split(' '))
                    {
                        if (sayac % 3 == 0)
                        {
                            comboBox1.Items.Add(i);
                        }
                            sayac++; //sayac%3= 0 olduğu durumlar item descriptionın olduğu yerler
                    }
                }
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OrderDetail orderDetail = new OrderDetail();
            Item item = new Item();


            label15.Text = orderDetail.CalcSubTotal(Convert.ToInt32(textBox1.Text),item).ToString();
            label10.Text = orderDetail.CalcWeight(Convert.ToInt32(textBox1.Text),item).ToString();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            //%18
            if (radioButton2.Checked)
                label1.Text = "Active";
            else if (radioButton1.Checked)
                label1.Text = "Active";
        }
    }
}
