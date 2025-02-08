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
            Console.WriteLine("True | False Question");
            Console.WriteLine("Please Enter Question Body");
            string? body = Console.ReadLine();
            Console.WriteLine("Please Enter Question mark");
            float.TryParse(Console.ReadLine(), out float mark);
            Answer[] answer =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };
            Console.WriteLine("Please Enter The Right Answer Id (1 For True | 2 For False)");
            Byte.TryParse(Console.ReadLine(), out byte rightAnswer);
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
