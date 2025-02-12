﻿using Demo.Answers;
using Demo.Exams;
using Demo.Questions;
using Demo.Subjects;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject() { SubjectId = 1 , SubjectName= "OOP" };
            subject.CreateExam();

            Console.WriteLine("Do You Want To Start Exam (Y|N)");
            Char.TryParse(Console.ReadLine(), out char start);
            if (start == 'Y' || start == 'y')
            {
                Console.Clear();
                subject.Exam.ShowExam();
            }
            else if (start == 'N' || start == 'n')
            {
                return;
            }

        }
    }
}
