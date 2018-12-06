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
            formTanuloSzerepkor.Show();
        }

        private void buttonSzerepkorTanar_Click(object sender, EventArgs e)
        {
            FormTanarSzerepkor formTanarSzerepkor = new FormTanarSzerepkor();
            formTanarSzerepkor.Show();

        }

        private void buttonSzerepkorSzulo_Click(object sender, EventArgs e)
        {
            FormSzuloSzerepkor formSzuloSzerepkor = new FormSzuloSzerepkor();
            formSzuloSzerepkor.Show();


        }
    }
}
