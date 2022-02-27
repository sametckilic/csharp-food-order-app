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
    public partial class FormNewPassword : Form
    {
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);

        public FormNewPassword()
        {
            InitializeComponent();
            lbluserName.Text = FormForgetPassword.user;        
        }

        private void btnChangePassword_Click(object sender, EventArgs e)
        {
            if (txtNewPass.Text.Equals(txtNewPass1.Text))
            {
                sqlConnection.Open();
                SqlCommand sqlCommand1 = new SqlCommand("UPDATE Tbl_Cstmr set Password ='" + txtNewPass.Text + "' where Email = '" + lbluserName.Text + "'", sqlConnection);
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("Şifreniz başarıyla değiştirilmiştir");
                sqlConnection.Close();
                this.Hide();
            }
            else MessageBox.Show("Girdiğiniz şifreler uyuşmamaktadır.");
            }
    }
}
