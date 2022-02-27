using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormCorpLogin : Form
    {
        public FormCorpLogin()
        {
            InitializeComponent();
        }

        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";

        SqlConnection sqlConnection = new SqlConnection(sql);
        private void lnkLblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT Username,Password FROM Tbl_Admin", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Boolean found = true;
            while (sqlDataReader.Read())
            {


                if (txtUsername.Text.Equals(sqlDataReader[0].ToString()) && txtPassword.Text.Equals(sqlDataReader[1].ToString()))
                {

                    this.Hide();
                    sqlDataReader.Close();
                    found = false;
                    FormCorp formCorp = new FormCorp();
                    formCorp.Show();
                    break;


                }
            }
            if (found)
            {
                MessageBox.Show("Hata Lütfen Tekrar Deneyiniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sqlDataReader.Close();
            sqlConnection.Close();
        }

        private void FormCorpLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
