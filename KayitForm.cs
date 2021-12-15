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
    public partial class KayitForm : Form
    {
        public KayitForm()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=pcBaro;Initial Catalog=nesnekayit;Integrated Security=True");

        private void KayitForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKayit_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("insert into tablekayit (Ad,Soyad,KullaniciAdi,Sifre) Values ('" + txtAd.Text.ToString() + "','" + txtSoyad.Text.ToString() + "','" + txtid.Text.ToString() + "','" + txtpw.Text.ToString() + "')", baglanti);
            komut.ExecuteNonQuery();
            MessageBox.Show("Başarıyla Kayıt Oldunuz.");
            baglanti.Close();
            LoginForm lgn = new LoginForm();
            lgn.Show();
            this.Hide();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void btnGeri_Click(object sender, EventArgs e)
        {
            LoginForm lgn = new LoginForm();
            lgn.Show();
            this.Hide();
        }
    }
}
