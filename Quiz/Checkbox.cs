using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Checkbox : Question
    {
        public List<string> Answers { get; set; } = new List<string>();

        public Checkbox(string questionHeader, string questionBody, List<string> answer) : base(questionHeader, questionBody)
        {
            Answers = answer;
        }
    }
}
