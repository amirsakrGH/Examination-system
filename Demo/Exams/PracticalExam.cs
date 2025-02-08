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
            foreach (var item in Question)
            {
                Console.WriteLine($"{item.HeaderOfQuestion}: {item.CorrectAnswer.AnswerText}");
            }

        }
    }
}
