using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7_Studio
{
    public class CheckBoxes : Question
    {
        public List<int> CorrectAnswer2 = new List<int> { get; set; }
        public List<string> AnswerChoices2 = new List<string> { get; set;}

        public CheckBoxes(string questionText, int pointValue, List<int> correctAnswer2, List<string> answerChioices2) : base(questionText, pointValue)
        {
            CorrectAnswer2 = correctAnswer2;
            AnswerChioices2 = answerChioices2;
        }

     }
}

