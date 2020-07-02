using System;
using System.Collections.Generic;

namespace Quiz
{
    public class Quiz
    {
        public List<Question> Questions { get; } = new List<Question>();


        public Quiz()
        {

        }

        public void AddQuestion(Question question)
        {
            Questions.Add(question);
        }

        public void Start()
        {
            int correct = 0;
            int wrong = 0;
            foreach (Question question in Questions)
            {
                Console.WriteLine("Question " + question.QuestionNo + "\n");
                Console.WriteLine(question.QuestionHeader + question.QuestionBody);
                Type type = question.GetType();
                string answer = Console.ReadLine().ToLower();
                while (answer.Length > 80)
                {
                    Console.WriteLine("Your answer must be less than 80 characters!");
                    answer = Console.ReadLine().ToLower();
                }
                if (type.Equals(typeof(MultipleChoice)))
                {
                    if (answer == (question as MultipleChoice).Answer)
                    {
                        Console.WriteLine("Correct!");
                        correct++;
                    }
                    else
                    {
                        Console.WriteLine("Wrong!");
                        wrong++;
                    }
                }
                else if (type.Equals(typeof(Checkbox)))
                {
                    foreach (string item in (question as Checkbox).Answers)
                    {
                        if (answer.Contains(item))
                        {
                            correct++;
                        }
                        else
                        {
                            wrong++;
                        }
                    }
                }

                else if (type.Equals(typeof(TrueFalse)))
                {
                    bool num = Convert.ToBoolean(answer);
                    if ( num == (question as TrueFalse).Answer)
                    {
                        correct++;
                    }
                    else
                    {
                        wrong++;
                    }
                }
                

            }
            Console.WriteLine("You've been asked " + Questions.Count + " questions.\n");
            if (correct == 0)
            {
                Console.WriteLine("All answers were wrong!");
            }
            else if (wrong == 0)
            {
                Console.WriteLine("Congrats! You nailed all of them.");
            }
            else
            {
                Console.WriteLine(correct + " of your answers were correct and " + wrong + " of them were wrong.");
            }
            
        }
    }
}
