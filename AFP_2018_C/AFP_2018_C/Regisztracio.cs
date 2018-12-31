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
    public partial class Regisztracio : Form
    {
        public Regisztracio()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            User user = new User(textBox_username.Text,textBox_password.Text,comboBox_szerepkor.Text);
            UsersTableManager manager = new UsersTableManager();
            if(manager.GetUser(user.Username) == null)
            {
                manager.Insert(user);
                MessageBox.Show("Sikeres regisztráció!");
            }
            else
            {
                MessageBox.Show("Létező felhasználónév!");
            }
        }
    }
}
