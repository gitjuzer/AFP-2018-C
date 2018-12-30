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

            UsersTableManager manager = new UsersTableManager();
            User user = manager.GetUser(this.textBox_username.Text, this.textBox_password.Text);
            //User user = new User("admin", "admin1231231231");
            if (user != null)
            {
                User.CurrentUser = user;
                FormTanuloSzerepkor formTanuloSzerepkor = new FormTanuloSzerepkor();
                this.Hide();
                formTanuloSzerepkor.ShowDialog();
                this.Close();
            }
            else
            {
                label3.Text = "Sikertelen bejelentkezés!";
                textBox_password.Text = "";
                textBox_username.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            UsersTableManager manager = new UsersTableManager();
            List<User> list = manager.SelectAll();
            for(int i = 0; i < list.Count; i++)
            {
                MessageBox.Show(list[i].Username+" " + list[i].Password + " " + list[i].Szerepkor);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Regisztracio regisztracio = new Regisztracio();
            regisztracio.ShowDialog();
        }
    }
}
