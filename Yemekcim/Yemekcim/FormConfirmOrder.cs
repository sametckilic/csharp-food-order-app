using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormConfirmOrder : Form
    {
        public FormConfirmOrder()
        {

            InitializeComponent();
        }
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";

        SqlConnection sqlConnection = new SqlConnection(sql);

        private void FormConfirmOrder_Load(object sender, EventArgs e)
        {
            lblBalance.Text = FormCstmr.balance;
            lblRsntName.Text = FormCstmr.chosenRstnName;
            lblSubAmount.Text = FormCstmr.subPrice.ToString();
            var list = FormCstmr.foodList;
            for (int i = 0; i < list.Count; i++)
            {
                lBoxCart.Items.Add(list[i]);
            }
        }



        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            FormCstmrAddBalance formCstmrAddBalance = new FormCstmrAddBalance();
            formCstmrAddBalance.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            if ((!txtNameSurname.Text.Equals("") && !txtNumber.Text.Equals("") && !cBoxCity.Text.Equals("") && !cBoxDistrict.Text.Equals("") && !cBoxNeighborhood.Text.Equals("") && !txtStreet.Text.Equals("") && !txtNo.Text.Equals("") && !txtApartNo.Text.Equals("") && !txtFloor.Text.Equals("")))
            {
                if (rButtonDoor.Checked)
                {
                    var result = MessageBox.Show("Siparişinizi vermek istediğinizden emin misiniz?" , "Sipariş Onay", MessageBoxButtons.OKCancel);
                    if(result == DialogResult.OK)
                    {
                        
                        SqlCommand sqlCommand1 = new SqlCommand("SELECT Balance FROM Tbl_Rsnt WHERE Username ='" + FormCstmr.chosenRstn + "'", sqlConnection);
                        SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                        int rsntBalance = 0;
                        while (sqlDataReader.Read())
                        {
                            rsntBalance = Convert.ToInt32(sqlDataReader[0]) + Convert.ToInt32(lblSubAmount.Text);
                        }
                        
                        sqlDataReader.Close();
                        SqlCommand sqlCommand2 = new SqlCommand("UPDATE Tbl_Rsnt SET Balance = " + rsntBalance.ToString() + " WHERE Username = '" + FormCstmr.chosenRstn + "'", sqlConnection);
                        sqlCommand2.ExecuteNonQuery();
                        SqlCommand sqlCommand3 = new SqlCommand("INSERT INTO Tbl_Order(NameSurname,Address,TheOrder,PaymentType,OrderTime,RsntName,RsntUsername,Number,UserID) VALUES(@name,@address,@order,@payment,@ordertime,@rsnt,@rsntusername,@number,@userid)", sqlConnection);
                        sqlCommand3.Parameters.AddWithValue("@name", txtNameSurname.Text);
                        sqlCommand3.Parameters.AddWithValue("@address", cBoxNeighborhood.Text + " " + txtStreet.Text + " No:" + txtNo.Text + " Kat: " + txtFloor.Text + " Daire No:" + txtApartNo.Text + " " + cBoxCity.Text + @"/" + cBoxDistrict.Text);
                        String foodnames = "";
                        foreach (string foods in FormCstmr.foodList)
                        {
                            foodnames = foods + " " + foodnames;
                        }
                        sqlCommand3.Parameters.AddWithValue("@order", foodnames);
                        sqlCommand3.Parameters.AddWithValue("@payment", "Kapıda Ödeme");
                        sqlCommand3.Parameters.AddWithValue("@ordertime", DateTime.Now);
                        sqlCommand3.Parameters.AddWithValue("@rsnt", lblRsntName.Text);
                        sqlCommand3.Parameters.AddWithValue("@rsntusername", FormCstmr.chosenRstn);
                        sqlCommand3.Parameters.AddWithValue("@number", txtNumber.Text);
                        sqlCommand3.Parameters.AddWithValue("@userid", FormCstmrLogin.id);
                        sqlCommand3.ExecuteNonQuery();
                        MessageBox.Show("Siparişiniz başarıyla alınmıştır.");
                        this.Hide();
                        Application.OpenForms["FormCstmr"].Close();
                        new FormCstmr().Show();
                        lBoxCart.Items.Clear();


                    }

                }
                else if (rButtonWallet.Checked)
                {
                    int newBalance = Convert.ToInt32(lblBalance.Text) - Convert.ToInt32(lblSubAmount.Text);
                    if (newBalance > 0)
                    {
                        var result = MessageBox.Show("Siparişinizi vermek istediğinizden emin misiniz?\n" +
                      "Bakiyeniz: " + lblBalance.Text + "\n" +
                      "Sipariş tutarı: " + lblSubAmount.Text + "\n" +
                       "Yeni bakiyeniz: " + newBalance.ToString(), "Sipariş Onay", MessageBoxButtons.OKCancel);
                        if (result == DialogResult.OK)
                        {
                            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Cstmr SET Balance = " + newBalance + " WHERE id = '" + FormCstmrLogin.id + "'", sqlConnection);
                            sqlCommand.ExecuteNonQuery();
                            lblBalance.Text = newBalance.ToString();
                            SqlCommand sqlCommand1 = new SqlCommand("SELECT Balance FROM Tbl_Rsnt WHERE Username ='" + FormCstmr.chosenRstn + "'", sqlConnection);
                            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
                            int rsntBalance = 0;
                            while (sqlDataReader.Read())
                            {
                                rsntBalance = Convert.ToInt32(sqlDataReader[0]) + Convert.ToInt32(lblSubAmount.Text);
                            }
                            sqlDataReader.Close();
                            SqlCommand sqlCommand2 = new SqlCommand("UPDATE Tbl_Rsnt SET Balance = " + rsntBalance.ToString() + " WHERE Username = '" + FormCstmr.chosenRstn + "'", sqlConnection);
                            sqlCommand2.ExecuteNonQuery();
                            SqlCommand sqlCommand3 = new SqlCommand("INSERT INTO Tbl_Order(NameSurname,Address,TheOrder,PaymentType,OrderTime,RsntName,RsntUsername,Number,UserID) VALUES(@name,@address,@order,@payment,@ordertime,@rsnt,@rsntusername,@number,@userid)", sqlConnection);
                            sqlCommand3.Parameters.AddWithValue("@name",txtNameSurname.Text);
                            sqlCommand3.Parameters.AddWithValue("@address",cBoxNeighborhood.Text + " " + txtStreet.Text + " No:" + txtNo.Text + " Kat: " + txtFloor.Text +" Daire No:" + txtApartNo.Text + " " + cBoxCity.Text + @"/" + cBoxDistrict.Text);
                            String foodnames = "";
                            foreach(string foods in FormCstmr.foodList)
                            {
                                foodnames += foods;
                            }
                            sqlCommand3.Parameters.AddWithValue("@order",foodnames);
                            sqlCommand3.Parameters.AddWithValue("@payment","Cüzdan (ÖDENDİ)");
                            sqlCommand3.Parameters.AddWithValue("@ordertime",DateTime.Now);
                            sqlCommand3.Parameters.AddWithValue("@rsnt",lblRsntName.Text);
                            sqlCommand3.Parameters.AddWithValue("@rsntusername", FormCstmr.chosenRstn);
                            sqlCommand3.Parameters.AddWithValue("@number",txtNumber.Text);
                            sqlCommand3.Parameters.AddWithValue("@userid", FormCstmrLogin.id);
                            sqlCommand3.ExecuteNonQuery();
                            MessageBox.Show("Siparişiniz başarıyla alınmıştır.");
                            Application.OpenForms["FormCstmr"].Close();
                            new FormCstmr().Show();
                            this.Hide();
                            lBoxCart.Items.Clear();
                        }

                    }
                    else MessageBox.Show("Yetersiz Bakiye!");
                } 
                else MessageBox.Show("Lütfen ödeme türünü seçiniz.");
            }
            else MessageBox.Show("Lütfen adresi tam olarak doldurunuz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            sqlConnection.Close();
        }
    }
}