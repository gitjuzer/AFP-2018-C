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
    public partial class FormTanarCsoportjaim : Form
    {
        public FormTanarCsoportjaim()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormTanarSzerepkor();
            this.Hide();
            myForm.ShowDialog();
            this.Close();

        }
    }
}
