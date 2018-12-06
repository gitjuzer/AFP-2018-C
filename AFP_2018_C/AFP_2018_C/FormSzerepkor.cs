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
    public partial class FormSzerepkor : Form
    {
        public FormSzerepkor()
        {
            InitializeComponent();
        }

        private void buttonSzerepkorTanulo_Click(object sender, EventArgs e)
        {
            FormTanuloSzerepkor formTanuloSzerepkor = new FormTanuloSzerepkor();
            this.Hide();
            formTanuloSzerepkor.ShowDialog();
            this.Close();
        }

        private void buttonSzerepkorTanar_Click(object sender, EventArgs e)
        {
            FormTanarSzerepkor formTanarSzerepkor = new FormTanarSzerepkor();
            this.Hide();
            formTanarSzerepkor.Show();
            this.Close();
        }

        private void buttonSzerepkorSzulo_Click(object sender, EventArgs e)
        {
            FormSzuloSzerepkor formSzuloSzerepkor = new FormSzuloSzerepkor();
            this.Hide();
            formSzuloSzerepkor.Show();
            this.Close();

        }
    }
}
