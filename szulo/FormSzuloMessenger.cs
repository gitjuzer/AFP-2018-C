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
    public partial class FormSzuloMessenger : Form
    {
        public FormSzuloMessenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSzuloSzerepkor formSzerepkor = new FormSzuloSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();
        }

        private void buttonTovabbTemakorhoz_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FormSzuloMessengerSzuloDiak szulodiak = new FormSzuloMessengerSzuloDiak();
                this.Hide();
                szulodiak.ShowDialog();
                this.Close();
            }
            else if (radioButton3.Checked)
            {
                FormSzuloMessengerSzulo szulo = new FormSzuloMessengerSzulo();
                this.Hide();
                szulo.ShowDialog();
                this.Close();

            }
            else if (radioButton2.Checked)
            {
                FormSzuloMessengerSzuloTanar szulotanar = new FormSzuloMessengerSzuloTanar();
                this.Hide();
                szulotanar.ShowDialog();
                this.Close();


            }
            else if (radioButton7.Checked)
            {
                FormSzuloMessengerAdminSzulo adminszulo = new FormSzuloMessengerAdminSzulo();
                this.Hide();
                adminszulo.ShowDialog();
                this.Close();


            }
        }
    }
}
