using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Sipariş_Otomasyonu
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }
        string[] adminid = { "admin" };
        string[] adminpw = { "1234" };

        SqlConnection baglanti = new SqlConnection("Data Source=pcBaro;Initial Catalog=nesnekayit;Integrated Security=True");
        private void btnKayitOl_Click(object sender, EventArgs e)
        {
            KayitForm kayt = new KayitForm();
            kayt.Show();
            this.Hide();

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            string query = "Select *from tablekayit where KullaniciAdi = '" + txtKullaniciAdLogin.Text.Trim() + "' and Sifre = '" + txtSifreLogin.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(query, baglanti);
            DataTable dtbl = new DataTable();
            sda.Fill(dtbl);
            if(dtbl.Rows.Count==1)
            {
                Form2_Order_ frm2 = new Form2_Order_();
                frm2.Show();
                this.Hide();
            }
            else if (adminid.Contains(txtKullaniciAdLogin.Text) && adminpw.Contains(txtSifreLogin.Text) && Array.IndexOf(adminid, txtKullaniciAdLogin.Text) == Array.IndexOf(adminpw, txtSifreLogin.Text))
            {

            }
            else
            {
                MessageBox.Show("Kullanıcı Adı ya da Şifreniz Yanlış");
                txtKullaniciAdLogin.Text = string.Empty;
                txtSifreLogin.Text = string.Empty;
            }
            baglanti.Close();


        }
    }
}
