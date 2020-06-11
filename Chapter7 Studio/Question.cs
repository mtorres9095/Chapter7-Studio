using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7_Studio
{
    class Question
    {
{
        public string QuestionText { get; set; }
        public int PointValue { get; set; }
        
        public Question(string questionText, int pointValue)
        {
            QuestionText = questionText;
            PointValue = pointValue;
            
        }

        public void DisplayQuestion()
        {
            
        }

        //public void RetestUpdate(bool size)
        //{
        //    Storage += size;
        //}
    }

}
}
