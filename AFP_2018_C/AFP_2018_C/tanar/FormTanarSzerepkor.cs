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
    public partial class FormTanarSzerepkor : Form
    {
        public FormTanarSzerepkor()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormSzerepkor formSzerepkor = new FormSzerepkor();
            this.Hide();
            formSzerepkor.ShowDialog();
            this.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var myForm = new FormTanarCsoportjaim();
            this.Hide();
            myForm.ShowDialog();
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormTanarMessenger messenger = new FormTanarMessenger();
            this.Hide();
            messenger.ShowDialog();
            this.Close();
        }
    }
}
