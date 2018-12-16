using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database.Entities
{
    class MathAnswer
    {
        private string text;
        private bool isCorrect;

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                if(value == null)
                {
                    throw new ArgumentNullException();
                }

                this.text = value;
            }
        }

        public bool IsCorrect
        {
            get
            {
                return this.isCorrect;
            }
            set
            {
                this.isCorrect = value;
            }
        }

        public MathAnswer(string text, bool isCorrect)
        {
            this.text = text;
            this.isCorrect = isCorrect;
        }
    }
}
