using System;
using System.Collections.Generic;


namespace Chapter7_Studio
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz myQuiz = new Quiz(new List<Question>());

            List<string> possAns1 = new List<string>() { "Ruby", "JavaScript", "PHP", "C#" };
            List<int> correctAns1 = new List<int>() { 2, 4 };
            CheckBox qs1 = new CheckBox("Which programming languages have we learned?", 2, possAns1, correctAns1);


            List<string> possAns2 = new List<string>() { "Honda", "Bugatti", "Toyota", "Ford", "Chevy" };
            MultipleChoice qs2 = new MultipleChoice("Which company makes the fastest car?", 1, possAns2, 2);

            TrueOrFalse qs3 = new TrueOrFalse("Dogs are the best?", 1, true);


            myQuiz.AddQuestion(qs1);
            myQuiz.AddQuestion(qs2);
            myQuiz.AddQuestion(qs3);

            myQuiz.RunQuiz();

            myQuiz.GradeQuiz();

        }
    }
}
