using Demo.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Questions
{
    internal class TrueFalseQuestion : Question
    {
        #region Methods

        public static TrueFalseQuestion CreateTFQ()
        {
            bool flag;
            Console.WriteLine("True | False Question");
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
                if (flag && mark > 0)
                    break;
            } while (true);
            Answer[] answer =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
            byte rightAnswer;
            do
            {
                Console.WriteLine("Please Enter The Right Answer Id (1 For True | 2 For False)");
                flag = Byte.TryParse(Console.ReadLine(), out rightAnswer);
                if (flag && (rightAnswer == 1 || rightAnswer == 2)) break;
            } while (true);
            return new TrueFalseQuestion()
            {
                HeaderOfQuestion = "True | False Question",
                BodyOfQuestion = body ?? "  ",
                Mark = mark,
                AnswerList = answer,
                CorrectAnswer = new Answer(rightAnswer)
            };
        }
        #endregion
    }
}
