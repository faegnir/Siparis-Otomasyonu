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
    public partial class Control_Panel_Form : Form
    {
        public Control_Panel_Form()
        {
            InitializeComponent();
            Populate();
        }
        SqlConnection con = new SqlConnection(@"Data Source=HAKANS-LAPTOP\SQLEXPRESS01;Initial Catalog=ControlPanel;Integrated Security=True"); // Kurulan SQL server Property-> Connection String -> Copy paste
        // ItemName varchar(50) , Weight int , Stock int , Price int , Description varchar(50) SQL data girelecek
        private void Populate()
        {
            con.Open();
            string query = "select * from ItemID";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            SqlCommandBuilder Builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            ItemListDG.DataSource = ds.Tables[0]; 
            con.Close();
        }
        int key = 0;

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(ItemNameTB.Text =="" || WeightTB.Text=="" || StockTB.Text=="" || PriceTB.Text=="" || DescriptionTB.Text=="")
            {
                MessageBox.Show("Missing Information");   
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "insert into ItemID values('" + ItemNameTB.Text + "','" + StockTB + "','" + PriceTB + "','"+DescriptionTB+"')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Created");
                    con.Close();
                }catch(Exception Ex)
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
                    string query = "delete from ItemListDG where ItemID=" + key + ";"; // Secilen Kayit delete tusuna basildigi zaman silinecek
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("ItemDeleted");
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
            if (ItemNameTB.Text == "" || WeightTB.Text == "" || StockTB.Text == "" || PriceTB.Text == "" || DescriptionTB.Text == "") // Herhangi bir TB bos olursa error mesaji vericek
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    con.Open();
                    string query = "update ItemListDG set ItemName=" + ItemNameTB.Text + ",Weight=" + WeightTB.Text + ",Stock=" +StockTB.Text+ ",Price=" +PriceTB.Text+",Description="+DescriptionTB.Text+"where CustomerID=" + key + ";"; // SQL de ItemListDG uzerinde yazilmis olan info updatelenecek
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Item Updated");
                    con.Close();
                    Populate();
                }
                catch (Exception Ex)
                {
                    MessageBox.Show(Ex.Message);
                }
            }
        }

        private void CustomerLabel_Click(object sender, EventArgs e)
        {
            Customer_Form Obj = new Customer_Form();
            Obj.Show();
            this.Hide(); // Ust kisimda Customer tiklanmasi halinde CustomerForm acilacak
        }

        private void ItemListDG_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            ItemNameTB.Text = ItemListDG.SelectedRows[0].Cells[1].Value.ToString();
            WeightTB.Text = ItemListDG.SelectedRows[0].Cells[2].Value.ToString();
            StockTB.Text = ItemListDG.SelectedRows[0].Cells[3].Value.ToString();
            PriceTB.Text = ItemListDG.SelectedRows[0].Cells[4].Value.ToString();
            DescriptionTB.Text = ItemListDG.SelectedRows[0].Cells[5].Value.ToString();
            if (ItemNameTB.Text == "")
            {
                key = 0;
            }
            else
            {
                key = Convert.ToInt32(ItemListDG.SelectedRows[0].Cells[0].Value.ToString()); // Burada egerki Listboxda bir urun secilirse otomatik olarak ust tarafa aktarilacak
            }
        }
    }

}
