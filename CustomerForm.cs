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

namespace WindowsFormsApp3
{
    public partial class Customer_Form : Form
    {
        public Customer_Form()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=HAKANS-LAPTOP\SQLEXPRESS01;Initial Catalog=ControlPanel;Integrated Security=True"); // SQL kuruldugu zaman propertyden connection string alinacak 
        // CustomerID int ,CustomerName varchar(50), CustomerPhone int, CustomerAdress varchar(50) SQL data girilecek
        private void Populate() 
        {
            con.Open();
            string query = "select * from CustomerID";
            SqlDataAdapter sda = new SqlDataAdapter(query, con); 
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            CustomerDG.DataSource = ds.Tables[0];  // Burada girilen data datagridde gozukecek
            con.Close();
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTB.Text == "" || CustomerPhoneTB.Text == "" || CustomerAddressTB.Text == "") // Herhangi bir TB bos olursa error mesaji vericek
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into CustomerID values('" + CustomerNameTB.Text + "','" + CustomerPhoneTB + "','" + CustomerAddressTB + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Created");
                    con.Close();
                    Populate();
                } catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (key == 0)
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "delete from CustomerDG where CustomerID=" + key + ";";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Customer Deleted");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (CustomerNameTB.Text == "" || CustomerPhoneTB.Text == "" || CustomerAddressTB.Text == "") // Herhangi bir TB bos olursa error mesaji vericek
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update CustomerDG set CustomerName='" + CustomerNameTB.Text + ",CustomerPhone=" + CustomerPhoneTB + ",CustomerAdress=" + CustomerAddressTB + "where CustomerID=" + key + ";"; // Kisaca SQL'den CustomerName , ID , Phone , Adress kayit edilecek
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Update successful");
                    con.Close();
                    //Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }
        int key = 0;

        private void ItemLabel_Click(object sender, EventArgs e) // Burda Label 1 tıklanması sonucu ilen Item(Control Panel) Formuna gidecek.
        {
            Control_Panel_Form Obj = new Control_Panel_Form();
            Obj.Show();
            this.Hide();
        }

        private void CustomerDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            CustomerNameTB.Text = CustomerDG.SelectedRows[0].Cells[1].Value.ToString();
            CustomerPhoneTB.Text = CustomerDG.SelectedRows[0].Cells[2].Value.ToString();
            CustomerAddressTB.Text = CustomerDG.SelectedRows[0].Cells[3].Value.ToString();
            if (CustomerNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(CustomerDG.SelectedRows[0].Cells[0].Value.ToString()); // Burada egerki Listboxda bir urun secilirse otomatik olarak ust tarafa aktarilacak
            }
        }
    } 
}