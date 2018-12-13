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
    public partial class FormTanarMessenger : Form
    {
        public FormTanarMessenger()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormTanarSzerepkor formSzerepkor = new FormTanarSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();
        }

        private void buttonTovabbTemakorhoz_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                FormTanarMessengerTanarDiak tanardiak = new FormTanarMessengerTanarDiak();
                this.Hide();
                tanardiak.ShowDialog();
                this.Close();
            }
            else if (radioButton3.Checked)
            {
                FormTanarMessengerTanar tanar = new FormTanarMessengerTanar();
                this.Hide();
                tanar.ShowDialog();
                this.Close();

            }
            else if (radioButton2.Checked)
            {
                FormTanarMessengerSzuloTanar szulotanar = new FormTanarMessengerSzuloTanar();
                this.Hide();
                szulotanar.ShowDialog();
                this.Close();


            }
            else if (radioButton7.Checked)
            {
                FormTanarMessengerAdminTanar admintanar = new FormTanarMessengerAdminTanar();
                this.Hide();
                admintanar.ShowDialog();
                this.Close();


            }
        }
    }
}
