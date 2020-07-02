using System;
using System.Collections.Generic;

namespace Quiz
{
    public class MultipleChoice : Question
    {
        public string Answer { get; set; }

        public MultipleChoice(string questionHeader, string questionBody, string answer) : base(questionHeader, questionBody)
        {
            Answer = answer;
        }

    }
}
