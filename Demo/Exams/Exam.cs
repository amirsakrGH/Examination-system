using Demo.Questions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Exams
{
    internal abstract class Exam
    {
        
        #region Properties
        public byte Time { get; set; }
        public byte NumberOfQuestion { get; set; }
        public Question[] Question { get; set; }
        #endregion

        #region Constructor
        protected Exam(byte time, byte numberOfQuestion)
        {
            Time = time;
            NumberOfQuestion = numberOfQuestion;
            Question = new Question[numberOfQuestion];

        }
        #endregion

        #region Methods
        public abstract void ShowExam(); 


        #endregion



    }
}
