using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Type_of_Question
{
    public class Answer 
    {
        public int AnswerID { get; set; }
        public string AnswerText { get; set; }
        public Answer(int answerID, string answerText)
        {
            AnswerID = answerID;
            AnswerText = answerText;
        }
    }
}
