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
        public string HeaderOfQusetion { get; set; }
        public string BodyOfQusetion { get; set; }
        public float Mark { get; set; }
        public Answer[] AnswersList { get; set; }
        public Answer RightAnswer { get; set; }
        public Answer? UserAnswer { get; set; }

        public Question(string headerOfQusetion, string bodyOfQusetion, float mark, Answer[] answersList, Answer rightAnswer)
        {
            HeaderOfQusetion = headerOfQusetion;
            BodyOfQusetion = bodyOfQusetion;
            Mark = mark;
            AnswersList = answersList;
            RightAnswer = rightAnswer;
        }

        public abstract void ShowQustion();
    }
}
