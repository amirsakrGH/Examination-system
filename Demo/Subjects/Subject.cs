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
            #region Start Input Validation
            Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final)");
            byte typeOfExam;
            bool check;
            bool flag;
            do
            {
                check = Byte.TryParse(Console.ReadLine(), out typeOfExam);
                if (!check || (typeOfExam != 1 && typeOfExam != 2))
                {
                    Console.WriteLine("Invalid, Please Enter (1 For Practical | 2 For Final)");
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            } while (flag);
            Console.WriteLine("Please Enter Time For Exam From (30 min to 180 min)");
            byte TimeOFExam;
            do
            {
                check = Byte.TryParse(Console.ReadLine(), out TimeOFExam); ;
                if (!check || (TimeOFExam < 30 || TimeOFExam > 180))
                {
                    Console.WriteLine("Invalid, Please Enter Time For Exam From (30 min to 180 min)");
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            } while (flag);
            Console.WriteLine("Please Enter The Number Of Questions");

            byte numberOfQuestions;
            do
            {
                check = Byte.TryParse(Console.ReadLine(), out numberOfQuestions);
                if (!check || (numberOfQuestions < 1 || numberOfQuestions > 255))
                {
                    Console.WriteLine("Invalid, Please Enter The Number Of Questions From (1  to 255 )");
                    flag = true;
                }
                else
                {
                    flag = false;
                }
            } while (flag);
            Console.Clear();
            #endregion


            #region Create Exam
            Question[] questions = new Question[numberOfQuestions];
            for (byte i = 0; i < numberOfQuestions; i++)
            {

                if (typeOfExam == 1) //Practical Exam
                {
                    questions[i] = MCQQuestion.CreateMCQ();
                }

                else if (typeOfExam == 2) //Final Exam
                {
                    Console.Clear();
                    Console.WriteLine("Please Enter Type Of Quetion (1 For MCQ | 2 For TFQ)");
                    byte typeOfQuestion;
                    do
                    {
                        check = Byte.TryParse(Console.ReadLine(), out typeOfQuestion);
                        if (!check || (typeOfQuestion != 1 && typeOfQuestion != 2))
                        {
                            Console.WriteLine("Invalid, Please Enter (1 For MCQ | 2 For TFQ)");
                            flag = true;
                        }
                        else
                        {
                            flag = false;
                        }

                    } while (flag);
                    Console.Clear();
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
                Exam = new PracticalExam(TimeOFExam, numberOfQuestions, questions);
            }
            else if (typeOfExam == 2)
            {
                Exam = new FinalExam(TimeOFExam, numberOfQuestions, questions);
            } 
            #endregion

        }

    }
}
