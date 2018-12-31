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
    public partial class LoginSzulo : Form
    {

        public Szulo szulo { get; set; }

        string szerepkor = FormSzerepkor.szerepkor;
        public LoginSzulo()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        public void button1_Click(object sender, EventArgs e)
        {

            label3.Text = "";

            UsersTableManager manager = new UsersTableManager();
            User user = manager.GetUser(this.textBox_username.Text, this.textBox_password.Text);
            if (user != null)
            {
                if (user.Szerepkor == "Szulo")
                {
                    User.CurrentUser = user;
                    FormSzuloSzerepkor formSzuloSzerepkor = new FormSzuloSzerepkor();
                    this.Hide();
                    formSzuloSzerepkor.ShowDialog();
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
    }

    public class Szulo
    {
        public bool IsAdmin { get; set; }

    }
}
