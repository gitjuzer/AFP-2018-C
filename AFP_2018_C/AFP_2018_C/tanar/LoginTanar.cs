using AFP_2018_C.Database;
using AFP_2018_C.Database.Entities;
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
    public partial class LoginTanar : Form
    {
        public LoginTanar()
        {
            InitializeComponent();
            textBox_password.PasswordChar='*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label3.Text = "";

            UsersTableManager manager = new UsersTableManager();
            User user = manager.GetUser(this.textBox_username.Text, this.textBox_password.Text);
            if (user != null)
            {
                if (user.Szerepkor == "Tanar")
                {
                    User.CurrentUser = user;
                    FormTanarSzerepkor formTanarSzerepkor = new FormTanarSzerepkor();
                    this.Hide();
                    formTanarSzerepkor.ShowDialog();
                    this.Close();
                }
                else { MessageBox.Show("Hozzáférés megtagadva!"); }
            }
            else
            {
                label3.Text = "Sikertelen bejelentkezés!";
                textBox_password.Text = "";
                textBox_username.Text = "";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regisztracio regisztracio = new Regisztracio();
            regisztracio.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormSzerepkor formSzerepkor = new FormSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();
        }
    }
}
