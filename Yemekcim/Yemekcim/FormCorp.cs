using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormCorp : Form
    {
        public FormCorp()
        {
            InitializeComponent();
        }
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";

        SqlConnection sqlConnection = new SqlConnection(sql);
        private void btnAdd_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            String sql = "CREATE TABLE Tbl_" + txtUsername.Text + " (FoodName varchar(35),Price smallint)";
            SqlCommand sqlCommand = new SqlCommand(sql, sqlConnection);
            sqlCommand.Parameters.AddWithValue("@table", txtUsername.Text);
            sqlCommand.ExecuteNonQuery();
            SqlCommand sqlCommand1 = new SqlCommand("INSERT INTO Tbl_Rsnt(Username,Password,RsntName) VALUES (@username,@password,@rsntName)", sqlConnection);
            sqlCommand1.Parameters.AddWithValue("@username", txtUsername.Text);
            sqlCommand1.Parameters.AddWithValue("@password", txtPassword.Text);
            sqlCommand1.Parameters.AddWithValue("@rsntName", txtName.Text);
            sqlCommand1.ExecuteNonQuery();
            MessageBox.Show("Restorant başarıyla eklendi!");
            SqlCommand sqlCommand2 = new SqlCommand("SELECT rsntName FROM Tbl_Rsnt", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand2.ExecuteReader();
            lBoxRsnt.Items.Clear();
            int counter = 0;
            while (sqlDataReader.Read())
            {
                counter++;
                lBoxRsnt.Items.Add(sqlDataReader[0].ToString());
            }
            lblSubRsnt.Text = counter.ToString();
           
            sqlConnection.Close();


        }

        private void FormCorp_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT rsntName FROM Tbl_Rsnt", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            int counter = 0;
            while (sqlDataReader.Read())
            {
                counter++;
                lBoxRsnt.Items.Add(sqlDataReader[0].ToString());
            }
            lblSubRsnt.Text = counter.ToString();
            sqlDataReader.Close();
            SqlCommand sqlCommand3 = new SqlCommand("SELECT SUM(Balance) FROM Tbl_Rsnt",sqlConnection);
            SqlDataReader sqlDataReader1 = sqlCommand3.ExecuteReader();
            while (sqlDataReader1.Read())
            {
                lblSubBalance.Text = sqlDataReader1[0].ToString();
            }
            sqlDataReader1.Close();
            sqlConnection.Close();
        }

        private void lnkLblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void FormCorp_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
