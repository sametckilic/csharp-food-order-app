using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;

namespace Yemekcim
{
    public partial class FormForgetPassword : Form
    {
        Random random;
        public static int randomNumber = 0;
        public static String user = "";
        public FormForgetPassword()
        {
            InitializeComponent();
            random = new Random();
            randomNumber = random.Next(100000, 999999);
            btnLogin.Visible = false;

        }

        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtVerCode.Text.Equals(randomNumber.ToString()))
            {
                user = txtEmail.Text;
                this.Hide();
                new FormNewPassword().Show();
               


            }

        
        }

        private void btnSendEmail_Click(object sender, EventArgs e)
        {
            sqlConnection.Open(); 
            
            SqlCommand sqlCommand = new SqlCommand("SELECT Email FROM Tbl_Cstmr",sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
            bool found = true;
            
            while (sqlDataReader.Read())
            {
                if(txtEmail.Text == sqlDataReader[0].ToString()){
                    SmtpClient smtpClient = new SmtpClient();
                    smtpClient.Port = 587;
                    smtpClient.Host = "smtp.gmail.com";
                    smtpClient.EnableSsl = true;
                    smtpClient.DeliveryMethod = SmtpDeliveryMethod.Network;
                    smtpClient.UseDefaultCredentials = false;
                    smtpClient.Credentials = new NetworkCredential("yemekcim2323@gmail.com", "wolftime23");


                    MailMessage mailMessage = new MailMessage();
                    mailMessage.From = new MailAddress("yemekcim2323@gmail.com");
                    mailMessage.To.Add(txtEmail.Text);
                    mailMessage.Subject = "Şifremi unuttum";
                    mailMessage.Body = "Doğrulama Kodunuz: " + randomNumber.ToString();
                    smtpClient.Send(mailMessage);
                    MessageBox.Show("Mail Başarıyla Gönderilmiştir.");
                    found = false;
                    btnLogin.Visible = true;
                    break;
                }
               
            }
            if (found)
            {
                MessageBox.Show("Yazdığınız mail adresi sistemimizde kayıtlı değildir");
            }
            sqlDataReader.Close();
            
            sqlConnection.Close();
        }
    }
}
