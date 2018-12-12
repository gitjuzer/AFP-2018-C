using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AFP_2018_C
{
    public partial class LoginTanulo : Form
    {
        public LoginTanulo()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";
            if (textBox_username.Text == "admin" && textBox_password.Text == "admin")
            {
                FormTanuloSzerepkor formTanuloSzerepkor = new FormTanuloSzerepkor();
                this.Hide();
                formTanuloSzerepkor.ShowDialog();
                this.Close();
            }
            label3.Text = "Sikertelen bejelentkezés!";
            textBox_password.Text = "";
            textBox_username.Text = "";
        }
    }
}
