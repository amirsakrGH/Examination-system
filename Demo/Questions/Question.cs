using Demo.Answers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Questions
{
    internal  class Question
    {

        #region Properties
        public string HeaderOfQuestion { get; set; }
        public string BodyOfQuestion { get; set; }
        public float Mark { get; set; }
        public Answer[] AnswerList { get; set; } // Options
        public Answer CorrectAnswer { get; set; }
        #endregion

        #region Methods
        public void ShowQuestion()
        {
            Console.WriteLine($"{HeaderOfQuestion} \t\t\t {Mark}");
            Console.WriteLine($"{BodyOfQuestion}");
            foreach (Answer answer in AnswerList)
            {
                Console.WriteLine(answer);
            }

        }
        #endregion


    }
}
