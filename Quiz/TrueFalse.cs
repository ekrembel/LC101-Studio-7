using System;

namespace Quiz
{
    public class TrueFalse : Question
    {
        public bool Answer { get; set; }
        public TrueFalse(string questionHeader, string questionBody, bool answer) : base(questionHeader, questionBody)
        {
            Answer = answer;
        }
    }
}
