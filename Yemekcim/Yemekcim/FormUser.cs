using System;
using System.Windows.Forms;

namespace Yemekcim
{
    public partial class FormUser : Form
    {
        public FormUser()
        {
            InitializeComponent();
        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

            FormCorpLogin formCorpLogin = new FormCorpLogin();
            formCorpLogin.Show();
            this.Hide();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

            FormCstmrLogin formCstmrLogin = new FormCstmrLogin();
            formCstmrLogin.Show();
            this.Hide();

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

            FormRsntLogin formRsntLogin = new FormRsntLogin();
            formRsntLogin.Show();
            this.Hide();

        }

        private void FormUser_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
