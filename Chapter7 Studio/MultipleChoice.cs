using System;
using System.Collections.Generic;

namespace Chapter7_Studio
{
    public class MultipleChoice : Question
    {        
        public int CorrectAnswer { get; set; }
        public List<string> PossibleAnswers { get; set; }
        
        public MultipleChoice(string questionText, int pointValue, List<string> possibleAnswers, int correctAnswer) : base (questionText, pointValue)
        {
            CorrectAnswer = correctAnswer;
            PossibleAnswers = possibleAnswers;
        }
        public override void DisplayAnswers()
        {
            foreach (string possibleAnswer in PossibleAnswers)
            {
                Console.WriteLine(possibleAnswer);
            }
        }

        public override int GetAnswers()
        {
            Console.WriteLine("Enter the number of your answer (1 or 2, etc) :");

            int userAnswer = Int32.Parse(Console.ReadLine());

            if (userAnswer == CorrectAnswer)
            {
                return 1;
            }

            return 0;
        }
    }

}
        


