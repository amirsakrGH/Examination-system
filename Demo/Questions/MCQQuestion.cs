using Demo.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Questions
{
    internal class MCQQuestion : Question
    {
        #region Methods

        public static MCQQuestion CreateMCQ()
        {
            Console.WriteLine("MCQ Questions");
            Console.WriteLine("Please Enter Question Body");
            string? body = Console.ReadLine();
            Console.WriteLine("Please Enter Question mark");
            float.TryParse(Console.ReadLine(), out float mark);
            Console.WriteLine("Choices Of Question");
            Answer[] answer = new Answer[3];
            for (byte i = 1; i < 4; i++)
            {
                Console.WriteLine($"Please Enter Choice Number {i}");
                answer[i - 1] = new Answer (i, Console.ReadLine());
            }
            Console.WriteLine("Please Enter The Right Answer Id");
            Byte.TryParse(Console.ReadLine(), out byte rightAnswer);
            return new MCQQuestion()
            { 
                HeaderOfQuestion = "MCQ Questions",
                BodyOfQuestion = body ?? "  ",
                Mark = mark,
                AnswerList = answer,
                CorrectAnswer = new Answer (rightAnswer)
            };
        }

        #endregion
    }
}
