using Examenation_System.Type_of_Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Exams_Types
{
    internal class FinalExam : Exam
    {
        public FinalExam(DateTime startExam, int nemberOfQuestions, Question[] questions)
          : base(startExam, nemberOfQuestions, questions)
        {
        }

        public override void ShowExam()
        {
            for (int i = 0; i < NemberOfQuestions; i++)
            {
                Question q = Questions[i];
                Console.WriteLine($"Qustion{i + 1}) : {q.BodyOfQusetion}");
                Console.WriteLine($"Your Answer -> {q.UserAnswer?.AnswerText}");
                Console.WriteLine($"Right Answer -> {q.RightAnswer.AnswerText}");
                Console.WriteLine($"Your Grade -> {q.Mark}");
            }
        }
    }
}
