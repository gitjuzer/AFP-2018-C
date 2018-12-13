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
    public partial class FormTanuloSzerepkor : Form
    {
        public FormTanuloSzerepkor()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonTovabbTemakorhoz_Click(object sender, EventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSzerepkor formSzerepkor = new FormSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonTovabbTemakorhoz_Click_1(object sender, EventArgs e)
        {

            if(radioButton1.Checked)
            {
                FormTanuloMatek formTanuloMatek = new FormTanuloMatek();
                this.Hide();
                formTanuloMatek.ShowDialog();
                this.Close();
            }
            else if(radioButton2.Checked)
            {
                FormTanuloInformatika formTanuloInformatika = new FormTanuloInformatika();
                this.Hide();
                formTanuloInformatika.ShowDialog();
                this.Close();

            }
            else if(radioButton3.Checked)
            {
                FormTanuloAngol formTanuloAngol = new FormTanuloAngol();
                this.Hide();
                formTanuloAngol.ShowDialog();
                this.Close();


            }
            else if (radioButton7.Checked)
            {
                FormTanuloNemet formTanuloNemet = new FormTanuloNemet();
                this.Hide();
                formTanuloNemet.ShowDialog();
                this.Close();


            }
            else if (radioButton8.Checked)
            {
                FormTanuloKornyezetismeret  formTanuloKornyezetismeret = new FormTanuloKornyezetismeret();
                this.Hide();
                formTanuloKornyezetismeret.ShowDialog();
                this.Close();
            }
            else if (radioButton9.Checked)
            {
                FormTanuloIrodalom formTanuloIrodalom = new FormTanuloIrodalom();
                this.Hide();
                formTanuloIrodalom.ShowDialog();
                this.Close();


            }
            else
            {
                MessageBox.Show("Témakör választása kötelező!");

            }


        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormTanuloMessenger messenger = new FormTanuloMessenger();
            this.Hide();
            messenger.ShowDialog();
            this.Close();
        }
    }
}
