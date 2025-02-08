using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Answers
{
    internal class Answer
    {
        public byte AnswerId { get; set; }
        public string? AnswerText { get; set; }

        public Answer(byte answerId)
        {
            AnswerId = answerId;
        }

        public Answer(byte answerId, string answerText)
        {
            AnswerId = answerId;
            AnswerText = answerText;
        }

        public override string ToString()
        {
            return $"{AnswerId}- {AnswerText}";
        }

    }
}
