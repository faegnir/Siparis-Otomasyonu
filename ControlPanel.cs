using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Sipariş_Otomasyonu
{
    public partial class ControlPanel : Form
    {
        public ControlPanel()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 itemAddForm = new Form1();
            itemAddForm.Show();
            this.Hide();
        }

        private void ControlPanel_Load(object sender, EventArgs e)
        {
            using (StreamReader sr = File.OpenText(Application.StartupPath + "\\Items\\orders.txt"))
            {
                string str = "";
                while ((str = sr.ReadLine()) != null)
                {
                   listBox1.Items.Add(str);
                }
            }
        }

        private void ControlPanel_FormClosed(object sender, FormClosedEventArgs e)
        {
            LoginForm lg = new LoginForm();
            lg.Show();
            this.Hide();
        }
    }
}
