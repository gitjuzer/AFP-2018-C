using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AFP_2018_C.Database.Entities
{
    public class EnvironmentalQuestion
    {
        private string text;
        private int score;
        private List<EnvironmentalAnswer> answers;

        public string Text
        {
            get
            {
                return this.text;
            }
            set
            {
                if (value == null)
                    throw new ArgumentNullException();

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
                if (value < 0)
                    throw new ArgumentException();
                
                this.score = value;
            }
        }

        public List<EnvironmentalAnswer> Answers
        {
            get
            {
                return this.answers;
            }
            set
            {
                answers = value;
            }
            
        }

        public EnvironmentalQuestion()
        {
            this.answers = new List<EnvironmentalAnswer>();
        }
    }
}
