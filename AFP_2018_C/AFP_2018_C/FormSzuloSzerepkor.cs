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
    public partial class FormSzuloSzerepkor : Form
    {
        public FormSzuloSzerepkor()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormSzerepkor formSzerepkor = new FormSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();


        }

        private void button1_Click(object sender, EventArgs e)
        {
            var myForm = new FormSzuloEredmenyek();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }
    }
}
