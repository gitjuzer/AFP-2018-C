using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database.Entities
{
    public class MathQuestion
    {
        private string text;
        private int score;
        private List<MathAnswer> answers;

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

        public int Score
        {
            get
            {
                return this.score;
            }
            set
            {
                if(value < 0)
                {
                    throw new ArgumentException();
                }

                this.score = value;
            }
        }

        public List<MathAnswer> Answers
        {
            set { answers = value; }
            get
            {
                return this.answers;
            }
        }

        public MathQuestion()
        {
            this.answers = new List<MathAnswer>();
        }
    }
}
