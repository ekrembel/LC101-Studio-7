using System;
using System.Collections.Generic;

namespace Quiz
{
    public abstract class Question
    {
        public int QuestionNo { get; }
        public static int NextQuestionNo = 1;
        public string QuestionHeader { get; }
        public string QuestionBody { get; }

        public Question(int questionNo, string questionHeader, string questionBody)
        {
            QuestionNo = questionNo;
            QuestionHeader = questionHeader;
            QuestionBody = questionBody;
       
        }

        public Question(string questionHeader, string questionBody) : this(NextQuestionNo, questionHeader, questionBody)
        {
            GenerateNumber();
        }

        public void GenerateNumber()
        {
            NextQuestionNo++;
        }
        //public abstract void AddQuestion(MultipleChoice question);
        ////public MultipleChoice GetQuestions()
        ////{
        ////    return QuestionList[];
        ////}

        //public abstract void AddQuestionList(Question item);

    }
}
