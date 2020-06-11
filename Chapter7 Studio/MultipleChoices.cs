using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7_Studio
{
    public class MultipleChoices : Question
    {        
        public int CorrectAnswer { get; set; }

        public List<string> AnswerChoices = new List<string>;
        public MultipleChoices(string questionText, int pointValue, int correctAnswer) : base (questionText, pointValue)
        {
            CorrectAnswer = correctAnswer;
        }
         
    }
        
}

