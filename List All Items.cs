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
    public partial class List_All_Items : Form
    {
        public List_All_Items()
        {
            InitializeComponent();
        }
        
        private void List_All_Items_Load(object sender, EventArgs e)
        {
            Listele();
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

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //MessageBox.Show(listBox1.SelectedItem.ToString()); seçilen item bilgilerini order details'a nasıl göndereceğiz
            // Order Detail menüsüne gider.
            Form2_Order_ orderDetailsMenu = new Form2_Order_();
            orderDetailsMenu.ShowDialog();
        }
    }
}
