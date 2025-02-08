using Demo.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Exams
{
    internal class PracticalExam : Exam
    {

        public PracticalExam(byte time, byte numberOfQuestion, Question[] question) : base(time, numberOfQuestion, question)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Practical Exam");
            for (int i = 0; i < base.Question.Length; i++)
            {
                base.Question[i].ShowQuestion();
                Console.WriteLine("Please Enter The Answer Id: ");
                byte.TryParse(Console.ReadLine(), out byte answerId);

            }

            Console.Clear();

            for (int i = 0; i < Question.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Question[i]}");
                Console.WriteLine($"Your Answer: ");
                Console.WriteLine($"Right Answer: {Question[i].CorrectAnswer.AnswerText}");
                Console.WriteLine("-----------------------------------------");
            }

        }
    }
}
