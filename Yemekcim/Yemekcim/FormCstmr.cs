using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace Yemekcim
{
    public partial class FormCstmr : Form
    {
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";

        SqlConnection sqlConnection = new SqlConnection(sql);
        public static String balance = "";
        public static String chosenRstn = "";
        public static String chosenRstnName = "";
        public static double foodPrice = 0d;
        public static List<String> foodList = new List<string>();
        public static int subPrice = 0;
        public FormCstmr()
        {
            InitializeComponent();
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT Username,Balance from Tbl_Cstmr WHERE id = " + FormCstmrLogin.id.ToString(), sqlConnection); ;
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            while (sqlDataReader.Read())
            {
                balance = sqlDataReader[1].ToString();
                lblUsername.Text = sqlDataReader[0].ToString();
                lblBalance.Text = balance;
            }
            sqlDataReader.Close();
            SqlCommand sqlCommand1 = new SqlCommand("SELECT RsntName,username FROM Tbl_Rsnt", sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                lBoxRsntList.Items.Add(sqlDataReader1[0].ToString());
            }
            sqlDataReader1.Close();
           
            sqlConnection.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormCstmrAddBalance formCstmrAddBalance = new FormCstmrAddBalance();
            formCstmrAddBalance.Show();

        }

        

        private void btnAddCart_Click(object sender, EventArgs e)
        {

            chosenRstnName = lBoxRsntList.SelectedItem.ToString();

            if (lBoxFoodAndPrice.SelectedItem == null)
            {
                MessageBox.Show("Hata!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                String[] array = lBoxFoodAndPrice.SelectedItem.ToString().Split(' ');
                foodPrice = Convert.ToDouble(array[array.Length - 2]);
                lBoxCart.Items.Add(lBoxFoodAndPrice.SelectedItem.ToString());
                lblSubAmount.Text = (Convert.ToInt32(lblSubAmount.Text) + (int)foodPrice).ToString();
                subPrice = Convert.ToInt32(lblSubAmount.Text);

            }

        }

        private void lnkLblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {

            /*int newBalance = Convert.ToInt32(lblBalance.Text) - Convert.ToInt32(lblSubAmount.Text);
            if (newBalance > 0)
            {
                var result = MessageBox.Show("Siparişinizi vermek istediğinizden emin misiniz?\n" +
              "Bakiyeniz: " + lblBalance.Text + "\n" +
              "Sipariş tutarı: " + lblSubAmount.Text + "\n" +
               "Yeni bakiyeniz: " + newBalance.ToString(), "Sipariş Onay", MessageBoxButtons.OKCancel);
                if (result == DialogResult.OK)
                {
                    sqlConnection.Open();
                    SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Cstmr SET Balance = " + newBalance.ToString() + " WHERE Username = '" + lblUsername.Text + "'", sqlConnection);
                    sqlCommand.ExecuteNonQuery();
                    lblBalance.Text = newBalance.ToString();
                    SqlCommand sqlCommand1 = new SqlCommand("SELECT Balance FROM Tbl_Rsnt WHERE Username ='" + chosenRstn + "'", sqlConnection);
                    SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                    int rsntBalance = 0;
                    while (sqlDataReader.Read())
                    {
                        rsntBalance = Convert.ToInt32(sqlDataReader[0]) + Convert.ToInt32(lblSubAmount.Text);
                    }
                    sqlDataReader.Close();
                    SqlCommand sqlCommand2 = new SqlCommand("UPDATE Tbl_Rsnt SET Balance = " + rsntBalance.ToString() + " WHERE Username = '" + chosenRstn + "'", sqlConnection);
                    sqlCommand2.ExecuteNonQuery();
                    MessageBox.Show("Siparişiniz başarıyla alınmıştır.");
                    lBoxCart.Items.Clear();
                    lBoxFoodAndPrice.Items.Clear();

                    sqlConnection.Close();
                }
            }*/
            foodList.Clear();
            if (lBoxCart.Items.Count != 0)
            {
                for(int i = 0; i < lBoxCart.Items.Count; i++)
                {
                    foodList.Add(lBoxCart.Items[i].ToString());

                }
                new FormConfirmOrder().Show();
            }
            else MessageBox.Show("Sepetiniz boş!");

        }

        public FormCstmr(String lbl)
        {
            InitializeComponent();
            lblBalance.Text = lbl;
        }

        private void lBoxRstnList_SelectedIndexChanged(object sender, EventArgs e)
        {
            sqlConnection.Open();
            lBoxCart.Items.Clear();
            lBoxFoodAndPrice.Items.Clear();
            lblSubAmount.Text = "0";
            SqlCommand sqlCommand1 = new SqlCommand("SELECT RsntName,username FROM Tbl_Rsnt", sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand1.ExecuteReader();
            int index = 0;
            while (sqlDataReader1.Read())
            {
                if (index == lBoxRsntList.SelectedIndex)
                {
                    chosenRstn = sqlDataReader1[1].ToString();
                }
                index++;
            }

            sqlDataReader1.Close();

            if (lBoxRsntList.SelectedIndex != -1) { SqlCommand sqlCommand = new SqlCommand("SELECT FoodName,Price FROM Tbl_" + chosenRstn, sqlConnection);
                SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    foodPrice = Convert.ToDouble(sqlDataReader[1]) * 1.25d;
                    lBoxFoodAndPrice.Items.Add(sqlDataReader[0].ToString() + " " + ((int)foodPrice).ToString() + " ₺");
                }
                sqlDataReader.Close();
            }

            sqlConnection.Close();
        }

        private void FormCstmr_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand3 = new SqlCommand("SELECT * FROM Tbl_Order Where UserID = '" + FormCstmrLogin.id + "'", sqlConnection);
            SqlDataReader sqlDataReader3 = sqlCommand3.ExecuteReader();
            while (sqlDataReader3.Read())
            {
                lBoxOrders.Items.Add("Order ID = " + sqlDataReader3[0] + " " + sqlDataReader3[1] + " " + sqlDataReader3[5]);
            }
            sqlDataReader3.Close();
            sqlConnection.Close();
        }
        public static string id = "";

        private void lBoxOrders_Click(object sender, EventArgs e)
        {
            String[] list = lBoxOrders.SelectedItem.ToString().Split(' ');
            id = list[3];
        }

        private void lBoxOrders_DoubleClick(object sender, EventArgs e)
        {
            sqlConnection.Open();
            new FormOrder2().Show();
            String[] list = lBoxOrders.SelectedItem.ToString().Split(' ');
            id = list[3];
            sqlConnection.Close();
        }
    }
}
