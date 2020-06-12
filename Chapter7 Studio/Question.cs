using System;

namespace Chapter7_Studio
{
    public abstract class Question
    {
        public string QuestionText { get; set; }
        public int PointValue { get; set; }
        
        protected Question(string questionText, int pointValue)
        {
            QuestionText = questionText;
            PointValue = pointValue;
        }

        public void DisplayQuestion()
        {
          Console.WriteLine(QuestionText);
        }
        public abstract void DisplayAnswers();
        public abstract void GetAnswers(); 
    }

}

