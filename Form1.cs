using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MarketProject
{
    public partial class Form1 : Form
    {

        string user = "admin";
        string password = "123456";

        public Form1()
        {
            InitializeComponent();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if(txt_user.Text == user && txt_password.Text == password)
            {
                this.Hide();
                Form2 form2 = new Form2();
                form2.Show();
            } else
            {
                MessageBox.Show("Kullanıcı adı veya şifre yanlış");
            }
        }

        private void enter(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}
