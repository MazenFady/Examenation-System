using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Type_of_Question
{
    public abstract class Answer : ICloneable
    {
        public int AnswerId { get; set; }
        public String AnswerText { get; set; }

        public Answer(int id, string text)
        {
            AnswerId = id;
            AnswerText = text;
        }
        public object Clone()
        {
            return new Answer(AnswerId, AnswerText);
        }
        public override string ToString()
        {
            return $"[{AnswerId}] {AnswerText}";
        }
    }
}
