using Examenation_System.Type_of_Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System
{
    public abstract class Question
    {
        public string Header { get; set; }
        public string Body { get; set; }
        public float Mark { get; set; }
        public Answer[] ListAnswer { get; set; }
        public int RightAnswer { get; set; }

        protected Question(string header, string body, float mark)
        {
            Header = header;
            Body = body;
            Mark = mark;
        }

        public virtual object Clone()
        {
            var cloned = (Question)MemberwiseClone();
            if (ListAnswer != null)
            {
                var arr = new Answer[ListAnswer.Length];
                for (int i = 0; i < ListAnswer.Length; i++)
                    arr[i] = (Answer)ListAnswer[i].Clone();
                cloned.ListAnswer = arr;
            }
            return cloned;
        }

        public abstract void ShowQuestion();
        public override string ToString()
        {
            return $"{Header} - Mark: {Mark}";
        }


    }
}
