﻿using System;
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
            if(textBox_username.Text =="admin" && textBox_password.Text == "admin")
            {
                    FormSzuloSzerepkor formSzuloSzerepkor = new FormSzuloSzerepkor();
                    this.Hide();
                    formSzuloSzerepkor.ShowDialog();
                    this.Close();
                szulo.IsAdmin = true;
             

            }
            label3.Text = "Sikertelen bejelentkezés!";
            textBox_password.Text = "";
            textBox_username.Text = "";
            szulo.IsAdmin = false;

        }
    }

    public class Szulo
    {
        public bool IsAdmin { get; set; }

    }


}
