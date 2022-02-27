using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormRsnt : Form
    {
        public static string id = "";
        public FormRsnt()
        {
            InitializeComponent();
        }
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);
        private void FormRsnt_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
           
            String sql = "SELECT RsntName,Balance FROM Tbl_Rsnt WHERE Username = '" + FormRsntLogin.rsntUsername + "'";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                lblRsnt.Text = sqlDataReader[0].ToString();
            }
            sqlDataReader.Close();
            SqlCommand sqlCommand2 = new SqlCommand("SELECT FoodName,Price FROM Tbl_" + FormRsntLogin.rsntUsername, sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                lBoxFood.Items.Add(sqlDataReader1[0] + " " + sqlDataReader1[1] + " ₺");
            }
            sqlDataReader1.Close();
            SqlCommand sqlCommand1 = new SqlCommand("SELECT Balance FROM Tbl_Rsnt WHERE Username ='" + FormRsntLogin.rsntUsername + "'", sqlConnection);
            SqlDataReader sqlDataReader2 = sqlCommand1.ExecuteReader();

            while (sqlDataReader2.Read())
            {
                lblSubBalance.Text = ((Convert.ToInt32(sqlDataReader2[0]) / 5) * 4).ToString();
            }
            sqlDataReader2.Close();
            SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM Tbl_Order Where RsntUsername = '" + FormRsntLogin.rsntUsername + "'", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                lBoxOrderList.Items.Add("Order ID = " + sqlDataReader3[0] + " " + sqlDataReader3[1] + " " + sqlDataReader3[5]);
            }
            sqlDataReader3.Close();

            sqlConnection.Close();
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand2 = new SqlCommand("SELECT FoodName FROM Tbl_" + FormRsntLogin.rsntUsername , sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand2.ExecuteReader();
            bool x = true;
            while (sqlDataReader1.Read())
            {
                if (sqlDataReader1[0].ToString().Equals(txtFoodName.Text))
                {
                    x = false;
                }
            }
            sqlDataReader1.Close();
            if (x == true)
            {
                SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO Tbl_" + FormRsntLogin.rsntUsername + "(FoodName,Price) VALUES (@foodname,@price)", sqlConnection);
                sqlCommand1.Parameters.AddWithValue("@foodname", txtFoodName.Text);
                sqlCommand1.Parameters.AddWithValue("@price", Convert.ToInt32(txtPrice.Text));
                sqlCommand1.ExecuteNonQuery();
                sqlConnection.Close();
                MessageBox.Show("Yemek başarıyla eklendi!");
                lBoxFood.Items.Add(txtFoodName.Text + " " + txtPrice.Text + " ₺");
            }
            else MessageBox.Show("Eklediğiniz yemek zaten var!");
        }

        private void lnkLblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }
        private void btnAddVisibleTrue(object sender, EventArgs e)
        {
            label1.Text = "Yemek Ekle: ";
            label2.Text = "Yemek Adı: ";
            label3.Text = "Fiyat: ";

            txtFoodName.Text = "";
            btnAdd.Visible = true;
        }

        private void btnAddVisibleFalse(object sender, EventArgs e)
        {
            label1.Text = "Yemek Güncelle: ";
            label2.Text = "Yemek ve Fiyatı: ";
            label3.Text = "Yeni Fiyat: ";

            txtFoodName.Text = lBoxFood.SelectedItem.ToString(); 
            btnAdd.Visible = false;
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            int index = lBoxFood.SelectedIndex;
            string foodname = "";
            SqlCommand sqlCommand1 = new SqlCommand("SELECT FoodName from Tbl_" + FormRsntLogin.rsntUsername, sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            int counter = 0;
            while (sqlDataReader.Read())
            {
                 if(counter == index)
                {
                    foodname = sqlDataReader[0].ToString();
                    break;
                }
                counter++;
            
            }
            sqlDataReader.Close();
           
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_" + FormRsntLogin.rsntUsername + " SET Price = "+ txtPrice.Text +" WHERE FoodName = '" + foodname + "'",sqlConnection);
            sqlCommand.ExecuteNonQuery();
            this.Hide();
            new FormRsnt().Show();
            MessageBox.Show("Fiyat başarıyla değiştirilmiştir");

            sqlConnection.Close();
        }

        private void lBoxOrderList_DoubleClick(object sender, EventArgs e)
        {
            sqlConnection.Open();
            new FormOrder().Show();
            String[] list = lBoxOrderList.SelectedItem.ToString().Split(' ');
            id = list[3];
            sqlConnection.Close();
        }

        private void lBoxOrderList_Click(object sender, EventArgs e)
        {

            if (lBoxOrderList.SelectedIndex != -1)
            {
                String[] list = lBoxOrderList.SelectedItem.ToString().Split(' ');
                id = list[3];
            }
        }

        private void FormRsnt_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM Tbl_Order Where RsntUsername = '" + FormRsntLogin.rsntUsername + "'", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            lBoxOrderList.Items.Clear();
            while (sqlDataReader3.Read())
            {
                lBoxOrderList.Items.Add("Order ID = " + sqlDataReader3[0] + " " + sqlDataReader3[1] + " " + sqlDataReader3[5]);
            }
            sqlDataReader3.Close();

            sqlConnection.Close();
        }
    }
}
