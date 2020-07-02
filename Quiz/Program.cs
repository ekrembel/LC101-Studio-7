using System;
using System.Collections.Generic;

namespace Quiz
{
    class Program
    {
        static void Main(string[] args)
        {
            MultipleChoice mq = new MultipleChoice("\nYour name? \n", "\na) Ekrem \nb) Ahmet\n", "b");
            MultipleChoice mq1 = new MultipleChoice("\nMy name? \n", "\na) Ekrem \nb) Ahmet\n", "a");

            List<string> answercb = new List<string> { "ekrem", "ahmet" }; 
            Checkbox cb = new Checkbox("\nOur names?\n", "\n1- Ekrem \n2- Ahmet \n3- Ismail", answercb);


            TrueFalse tf = new TrueFalse("\nMy name is Ahmet.\n", "\nTrue \nFalse", false);

            Quiz quiz = new Quiz();

            quiz.AddQuestion(mq);
            quiz.AddQuestion(mq1);
            quiz.AddQuestion(cb);
            quiz.AddQuestion(tf);
            quiz.Start();

        }
    }
}
