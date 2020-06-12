using System;
using System.Collections.Generic;

namespace Ch7_Studio
{
    public class Quiz
    {

        public List<Question> Questions { get; set; }
        public int Score { get; set; } // user score in quiz
        private int Total { get; set; } // total points for quiz

        public Quiz(List<Question> questions)
        {
            Questions = questions;
            Score = 0;
            Total = 0;

            foreach (Question qs in Questions)
            {
                Total += qs.PointValue;
            }
        }

        public void AddQuestion(Question qs)
        {
            Questions.Add(qs);
            Total += qs.PointValue;
        }

        public void RunQuiz()
        {
            foreach (Question qs in Questions)
            {
                Console.WriteLine("\n*********************\n");
                qs.DisplayQuestion();
                qs.DisplayAnswers();
                int points = qs.GetAnswers();

                Score += points;
            }
        }

        public void GradeQuiz()
        {
            Console.WriteLine($"The quiz is over! Your score is {Score} out of {Total}");
        }

    }
}
