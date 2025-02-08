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
            bool flag;
            Console.WriteLine("MCQ Questions");
            string? body;
            do
            {
                Console.WriteLine("Please Enter Question Body");
                body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(body));
            float mark;
            do
            {
                Console.WriteLine("Please Enter Question mark");
                flag = float.TryParse(Console.ReadLine(), out mark);
                if(flag && mark > 0 )
                    break;
            } while (true);
            Console.WriteLine("Choices Of Question");
            Answer[] answer = new Answer[3];
            for (byte i = 1; i < 4; i++)
            {
                string? inputAns;
                do
                {
                    Console.WriteLine($"Please Enter Choice Number {i}");
                    inputAns = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(inputAns));
                answer[i - 1] = new Answer (i, inputAns);
            }
            byte rightAnswer;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Id");
                flag = Byte.TryParse(Console.ReadLine(), out rightAnswer);
                if(flag && rightAnswer > 0 && rightAnswer < 4) break;
            } while (true);
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
