using Demo.Exams;
using Demo.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Subjects
{
    internal class Subject
    {
        public int SubjectId { get; set; }
        public string SubjectName { get; set; }
        public Exam Exam { get; set; }

        public Subject() { }
        public Subject(int subjectId, string subjectName)
        {
            SubjectId = subjectId;
            SubjectName = subjectName;
        }

        public void CreateExam()
        {
            Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final)");
            Byte.TryParse(Console.ReadLine(), out byte typeOfExam);
            Console.WriteLine("Please Enter Time For Exam From (30 min to 180 min)");
            Byte.TryParse(Console.ReadLine(), out byte TimeOFExam);
            Console.WriteLine("Please Enter The Number Of Questions");
            Byte.TryParse(Console.ReadLine(), out byte numberOfQuestions);

            Question[] questions = new Question[numberOfQuestions];

            for (byte i = 0; i < numberOfQuestions; i++)
            {
                if (typeOfExam == 1)
                {
                    questions[i] = MCQQuestion.CreateMCQ();
                }
                else if (typeOfExam == 2)
                {
                    Console.WriteLine("Please Enter Type Of Quetion (1 For MCQ | 2 For TFQ)");
                    byte typeOfQuestion;
                    bool check;
                    do
                    {
                        check = Byte.TryParse(Console.ReadLine(), out typeOfQuestion);

                    } while ((typeOfQuestion == 1 || typeOfQuestion == 2) && check);

                    if (typeOfQuestion == 1)
                    {
                        questions[i] = MCQQuestion.CreateMCQ();
                    }
                    else if (typeOfQuestion == 2)
                    {
                        questions[i] = TrueFalseQuestion.CreateTFQ();
                    }

                }
            }


            if (typeOfExam == 1)
            {
                Exam = new PracticalExam(TimeOFExam,numberOfQuestions);
            }
            else if (typeOfExam == 2)
            {

            }

        }

    }
}
