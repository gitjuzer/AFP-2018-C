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
    public partial class FormSzuloMessengerSzuloTanar : Form
    {
        public FormSzuloMessengerSzuloTanar()
        {
            InitializeComponent();
        }

        private void FormSzuloMessengerSzuloTanar_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Text.ASCIIEncoding enc = new System.Text.ASCIIEncoding();
                byte[] msg = new byte[1500];
                msg = enc.GetBytes(Szoveg.Text);
                Chat.Items.Add("Te:" + Szoveg.Text);
                Szoveg.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSzuloMessenger formSzerepkor = new FormSzuloMessenger();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();
        }
    }
}
