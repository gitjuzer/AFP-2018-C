using AFP_2018_C.Database;
using AFP_2018_C.Database.Entities;
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
    public partial class FormTanuloMatek : Form
    {
        private const int AnswerButtonCount = 3;

        private List<MathQuestion> list;
        private int currentQuestion;
        private Button[] answerButtons;

        public FormTanuloMatek()
        {
            InitializeComponent();
            this.answerButtons = new Button[AnswerButtonCount];
            this.answerButtons[0] = this.answerButton1;
            this.answerButtons[1] = this.answerButton2;
            this.answerButtons[2] = this.answerButton3;

            MathQuestionsManager manager = new MathQuestionsManager();
            this.list = manager.SelectAll();
            this.currentQuestion = 0;

            Action<object, MouseEventArgs> answerClicked = (obj, e) =>
            {
                int correctIndex = this.list[this.currentQuestion].Answers.FindIndex((x) => x.IsCorrect);
                if(obj.Equals(this.answerButtons[correctIndex]))
                {
                    // Jó válasz
                    User.CurrentUser.Score += this.list[this.currentQuestion].Score;
                }
                else
                {
                    // Helytelen válasz
                    MessageBox.Show("Helytelen válasz!", "HIBA", MessageBoxButtons.OK);
                }

                this.GetNextQuestion();
            };
        }

        private void GetNextQuestion()
        {
            if(this.currentQuestion >= this.list.Count - 1)
            {
                // VÉGZETT
                FormTanuloSzerepkor newForm = new FormTanuloSzerepkor();
                newForm.Show();
                this.Hide();
            }
            else
            {
                this.currentQuestion++;
            }
        }
    }
}
