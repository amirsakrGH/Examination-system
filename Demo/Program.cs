using Demo.Answers;
using Demo.Exams;
using Demo.Questions;
using Demo.Subjects;

namespace Demo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //0 - 255
            //Console.WriteLine("Please Enter The Type Of Exam (1 For Practical | 2 For Final)");
            //Byte.TryParse(Console.ReadLine(), out byte typeOfExam);
            //Console.WriteLine("Please Enter Time For Exam From (30 min to 180 min)");
            //Byte.TryParse(Console.ReadLine(), out byte TimeOFExam);
            //Console.WriteLine("Please Enter The Number Of Questions");
            //Byte.TryParse(Console.ReadLine(), out byte numberOfQuestions);






            #region Practical Exam
            //Subject subOOP = new Subject() { SubjectId = 1, SubjectName = "OOP" };

            //Answer[] mcqAns =
            //{
            //    new Answer(1,"A"),
            //    new Answer(2,"B"),
            //    new Answer(3,"C"),
            //    new Answer(4,"D")
            //};

            //MCQQuestion mcq = new MCQQuestion()
            //{
            //    HeaderOfQuestion = "Q1",
            //    BodyOfQuestion = "Capital of egypt ?",
            //    Mark = 5,
            //    AnswerList = mcqAns,
            //    CorrectAnswer = mcqAns[1]
            //};

            //PracticalExam practicalExam = new PracticalExam(2, 1);


            //practicalExam.Question[0] = mcq;

            //subOOP.CreateExam(practicalExam);
            //subOOP.Exam.ShowExam();

            //#endregion

            //#region Final Exam
            //Subject subAdvanced = new Subject() { SubjectId = 1, SubjectName = "Advanced" };

            //Answer[] mcqFinalAns =
            //{
            //    new Answer(1,"A"),
            //    new Answer(2,"B"),
            //    new Answer(3,"C"),
            //    new Answer(4,"D")
            //};

            //MCQQuestion mcqFinal = new MCQQuestion()
            //{
            //    HeaderOfQuestion = "Q1",
            //    BodyOfQuestion = "Which of the following is NOT a pillar of OOP?",
            //    Mark = 5,
            //    AnswerList = mcqFinalAns,
            //    CorrectAnswer = mcqFinalAns[2]
            //};

            //Answer[] tfqFinalAns =
            //{
            //    new Answer(1,"true"),
            //    new Answer(2,"false"),
            //};

            //TrueFalseQuestion tfqFinal = new TrueFalseQuestion()
            //{
            //    HeaderOfQuestion = "Q2",
            //    BodyOfQuestion = "Class in OOP can have multiple constructors?",
            //    Mark = 5,
            //    AnswerList = tfqFinalAns,
            //    CorrectAnswer = tfqFinalAns[0]
            //};

            //FinalExam final = new FinalExam(3, 2);

            //final.Question[0] = mcqFinal;
            //final.Question[1] = tfqFinal;

            //subAdvanced.CreateExam(final);
            //subAdvanced.Exam.ShowExam();

            #endregion
        }
    }
}
