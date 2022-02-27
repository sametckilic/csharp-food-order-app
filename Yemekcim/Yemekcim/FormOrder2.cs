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
    public partial class FormOrder2 : Form
    {
        private static string sql = @"Data Source=yemekcimdb.czvhhc8ooloo.us-east-2.rds.amazonaws.com;Initial Catalog=YemekcimDb;User ID=admin;Password =23Boomslang.";


        SqlConnection sqlConnection = new SqlConnection(sql);
        public FormOrder2()
        {
            InitializeComponent();
        }

        private void FormOrder_Load(object sender, EventArgs e)
        {
            sqlConnection.Open();

            SqlCommand sqlCommand = new SqlCommand("SELECT * FROM Tbl_Order WHERE OrderID = " + FormCstmr.id , sqlConnection);
            SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();

            while (sqlDataReader.Read())
            {
                lblName.Text = sqlDataReader[1].ToString();
                lblNumber.Text = sqlDataReader[8].ToString();
                lblPaymentType.Text = sqlDataReader[4].ToString();
                lblTime.Text = sqlDataReader[5].ToString();
                lblAddress.Text = sqlDataReader[2].ToString();
                String[] x = sqlDataReader[3].ToString().Split('?');
                String z = "";
                foreach (string y in x)
                {
                    z = y.Replace('?', '₺');
                    listBox1.Items.Add(z);

                }
            }

            sqlConnection.Close();
        }
    }
}