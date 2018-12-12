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
        public static string szerepkor;
        public FormSzerepkor()
        {
            InitializeComponent();
        }

        private void buttonSzerepkorTanulo_Click(object sender, EventArgs e)
        {
            szerepkor = "tanulo";
            LoginTanulo login = new LoginTanulo();
            this.Hide();
            login.ShowDialog();
            this.Close();
            /*
            FormTanuloSzerepkor formTanuloSzerepkor = new FormTanuloSzerepkor();
            this.Hide();
            formTanuloSzerepkor.ShowDialog();
            this.Close();*/
        }

        private void buttonSzerepkorTanar_Click(object sender, EventArgs e)
        {
            szerepkor = "tanar";
            LoginTanar login = new LoginTanar();
            this.Hide();
            login.ShowDialog();
            this.Close();
            /*
            FormTanarSzerepkor formTanarSzerepkor = new FormTanarSzerepkor();
            this.Hide();
            formTanarSzerepkor.ShowDialog();
            this.Close();*/
        }


        private void buttonSzerepkorSzulo_Click(object sender, EventArgs e)
        {
            szerepkor = "szulo";
            LoginSzulo login = new LoginSzulo();
            this.Hide();
            login.ShowDialog();
            this.Close();
            /*
            FormSzuloSzerepkor formSzuloSzerepkor = new FormSzuloSzerepkor();
            this.Hide();
            formSzuloSzerepkor.ShowDialog();
            this.Close();*/

        }

        private void button_kilepes_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
