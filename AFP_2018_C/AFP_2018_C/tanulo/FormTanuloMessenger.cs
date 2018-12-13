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
    public partial class FormTanuloMessenger : Form
    {
        public FormTanuloMessenger()
        {
            InitializeComponent();
        }

        private void FormTanuloMessenger_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTanuloSzerepkor formSzerepkor = new FormTanuloSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
  
        }

        private void buttonTovabbTemakorhoz_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FormTanuloMessengerTanarDiak tanardiak = new FormTanuloMessengerTanarDiak();
                this.Hide();
                tanardiak.ShowDialog();
                this.Close();
            }
            else if (radioButton3.Checked)
            {
                FormTanuloMessengerDiak diak = new FormTanuloMessengerDiak();
                this.Hide();
                diak.ShowDialog();
                this.Close();

            }
            else if (radioButton2.Checked)
            {
                FormTanuloMessengerSzuloDiak szulodiak = new FormTanuloMessengerSzuloDiak();
                this.Hide();
                szulodiak.ShowDialog();
                this.Close();


            }
            else if (radioButton7.Checked)
            {
                FormTanuloMessengerAdminDiak admindiak = new FormTanuloMessengerAdminDiak();
                this.Hide();
                admindiak.ShowDialog();
                this.Close();


            }
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
