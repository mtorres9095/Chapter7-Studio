using System;
using System.Collections.Generic;

namespace Chapter7_Studio
{
    public class CheckBox : Question
    {
        public List<string> PossibleAnswers { get; set; }
        private List<int> CorrectAnswers { get; set;}

        public CheckBox(string questionText, int pointValue, List<string> possibleAnswers, List<int> correctAnswers) : base(questionText, pointValue)
        {
            PossibleAnswers = possibleAnswers;
            CorrectAnswers = correctAnswers;
        }
        public void ShowAnswers()
        {
            foreach (string possibleAnswer in PossibleAnswers)
            {
                Console.WriteLine(possibleAnswer);
            }
        }
        public override int GetAnswers()
        {
            List<int> userAnswers = new List<int>();
            string userInput;
            Console.WriteLine("Select the best answer (could have multiple correct answers) (Write the answer number or ENTER stop)");
            
            do
            {
                Console.WriteLine("Write your answer: ");
                userInput = Console.ReadLine();

                if (userInput != "")
                {
                    userAnswers.Add(Int32.Parse(userInput));
                }

            } while (userInput != "" && userAnswers.Count <= CorrectAnswers.Count);

            int answeredCorrectly = CheckAnswers(userAnswers);

            return answeredCorrectly;
        }

        private int CheckAnswers(List<int> userAnswers)
        {
            int answeredCorrectly = 0;

            foreach (int answer in userAnswers)
            {
                if (CorrectAnswers.Contains(answer))
                {
                    answeredCorrectly++;
                }
            }

            return answeredCorrectly;
        }
    }
}
   

