﻿using Demo.Questions;
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
            bool flag;
            Console.WriteLine("Practical Exam");

            for (int i = 0; i < base.Question.Length; i++)
            {
                base.Question[i].ShowQuestion();
                byte inputId;
                do
                {
                    Console.WriteLine("Please Enter The Answer Id: ");
                    flag = byte.TryParse(Console.ReadLine(), out inputId);
                    if (flag && (inputId > 0 && inputId < 4)) break;

                } while (true);
                Console.WriteLine("-------------------------------------");
                base.Question[i].UserAnswerId = inputId;
            }

            Console.Clear();

            for (int i = 0; i < Question.Length; i++)
            {
                Console.WriteLine($"Question {i + 1}: {Question[i].BodyOfQuestion}");
                Console.WriteLine($"Your Answer: {Question[i].UserAnswerId}");
                Console.WriteLine($"Right Answer: {Question[i].CorrectAnswer.AnswerId}");
                Console.WriteLine("-----------------------------------------");
            }

        }
    }
}
