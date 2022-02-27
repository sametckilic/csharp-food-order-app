using System;
using System.Data.SqlClient;
using System.Windows.Forms;


namespace Yemekcim
{
    public partial class FormRegister : Form
    {
        public FormRegister()
        {
            InitializeComponent();
        }
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);
        private void btnLogin_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();
            bool x = true;
            SqlCommand sqlCommand1 = new SqlCommand("SELECT Username,Email FROM Tbl_Cstmr", sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand1.ExecuteReader();
            while (sqlDataReader.Read())
            {
                if (sqlDataReader[0].ToString().Equals(txtUsername.Text) || sqlDataReader[1].ToString().Equals(txtEmail.Text))
                {
                    x = false;
                }
            }
            sqlDataReader.Close();

            if (x)
            {
                if ((txtPassword.TextLength > 5) && (txtPassword.TextLength < 16))
                {
                    if (txtPassword.Text.Equals(txtPassword1.Text))
                    {

                        SqlCommand sqlCommand = new SqlCommand("INSERT INTO Tbl_Cstmr(Username,Password,Email) VALUES (@username,@password,@email)", sqlConnection);
                        sqlCommand.Parameters.AddWithValue("@username", txtUsername.Text);
                        sqlCommand.Parameters.AddWithValue("@password", txtPassword.Text);
                        sqlCommand.Parameters.AddWithValue("@email", txtEmail.Text);
                        sqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Başarıyla Üye Olundu!");
                        this.Hide();
                    }
                    else MessageBox.Show("Girdiğiniz şifreler birbirinden farklı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
                else { MessageBox.Show("Lütfen kullanıcı adı veya şifrenizin uzunluğunu kontrol ediniz. (Min: 6 , Max: 13)", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error); }
                
            }
            else MessageBox.Show("Yazdığınız kullanıcı adı veya email kullanılamıyor.");
            sqlConnection.Close();
        }

      
    }
}
