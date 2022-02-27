using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormCstmrAddBalance : Form
    {
        public FormCstmrAddBalance()
        {
            InitializeComponent();
        }
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);
        private void btnAddBalance_Click(object sender, EventArgs e)
        {
            sqlConnection.Open();

            int newBalance = Convert.ToInt32(txtBalance.Text) + Convert.ToInt32(FormCstmr.balance);
            SqlCommand sqlCommand = new SqlCommand("UPDATE Tbl_Cstmr SET Balance = " + newBalance.ToString() + " WHERE id = " + FormCstmrLogin.id.ToString(), sqlConnection);
            sqlCommand.ExecuteNonQuery();

            Application.OpenForms["FormCstmr"].Close();
            FormCollection formCollection = Application.OpenForms;
            foreach(Form form in formCollection)
            {
                if(form.Name == "FormConfirmOrder")
                {
                    Application.OpenForms["FormConfirmOrder"].Close();

                }
            }
            Form frm = new FormCstmr();
            frm.Show();
            this.Hide();
            sqlConnection.Close();
        }
    }
}
