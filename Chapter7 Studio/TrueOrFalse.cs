using System;
using System.Collections.Generic;
using System.Text;

namespace Chapter7_Studio
{
   public class TrueOrFalse : Question

    {
        private bool CorrectAnswer { get; set; }
    }
    public TrueOrFalse (bool trueOrFalse)
    {
        TrueOrFalse = trueOrFalse
    }
    public override void GetAnswers()
    {
        Console.WriteLine("1. John 2. Mary... What you name");
    }


}
