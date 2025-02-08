using Demo.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Exams
{
    internal class FinalExam : Exam
    {
        public FinalExam(int time, int numberOfQuestion) : base(time, numberOfQuestion)
        {
        }

        public override void ShowExam()
        {
            Console.WriteLine("Final Exam");
            foreach (var item in Question)
            {
                Console.WriteLine($"{item.HeaderOfQuestion}: {item.CorrectAnswer.AnswerText}       ({item.Mark})");
            }
        }
    }
}
