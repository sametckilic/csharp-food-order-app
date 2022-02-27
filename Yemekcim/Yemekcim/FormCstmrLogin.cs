using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormCstmrLogin : Form
    {
        public FormCstmrLogin()
        {
            InitializeComponent();
        }

        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);

        public static int id = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {

            sqlConnection.Open();
            SqlCommand sqlCommand = new SqlCommand("SELECT Username,Password,id FROM Tbl_Cstmr", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            Boolean found = true;

            while (sqlDataReader.Read())
            {


                if (txtUsername.Text.Equals(sqlDataReader[0].ToString()) && txtPassword.Text.Equals(sqlDataReader[1].ToString()))
                {
                    id = Convert.ToInt32(sqlDataReader[2]);
                    this.Hide();
                    FormCstmr formCstmr = new FormCstmr();
                    formCstmr.Show();
                    sqlDataReader.Close();
                    found = false;
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

        private void lnkLblMainMenu_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormUser formUser = new FormUser();
            formUser.Show();
            this.Hide();
        }

        private void lnkLblRegister_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FormRegister formRegister = new FormRegister();
            formRegister.Show();
        }


        private void lnkLblForgetPass_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new FormForgetPassword().Show();
        }

        private void FormCstmrLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();

        }
    }
}
