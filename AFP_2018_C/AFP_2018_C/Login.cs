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
    public partial class Login : Form
    {
        string szerepkor = FormSzerepkor.szerepkor;
        public Login()
        {
            InitializeComponent();
            textBox_password.PasswordChar = '*';
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(textBox_username.Text =="admin" && textBox_password.Text == "admin")
            {
                if (szerepkor == "tanulo")
                {
                    FormTanuloSzerepkor formTanuloSzerepkor = new FormTanuloSzerepkor();
                    this.Hide();
                    formTanuloSzerepkor.ShowDialog();
                    this.Close();
                }

                if (szerepkor == "tanar")
                {
                    FormTanarSzerepkor formTanarSzerepkor = new FormTanarSzerepkor();
                    this.Hide();
                    formTanarSzerepkor.ShowDialog();
                    this.Close();
                }

                if (szerepkor == "szulo")
                {
                    FormSzuloSzerepkor formSzuloSzerepkor = new FormSzuloSzerepkor();
                    this.Hide();
                    formSzuloSzerepkor.ShowDialog();
                    this.Close();
                }
            }
        }
    }
}
