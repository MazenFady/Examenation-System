using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Exams_Types
{
    public abstract class Exam
    {
        public DateTime StartExam { get; set; }
        public int NemberOfQuestions { get; set; }
        public Question[] Questions { get; set; }
        public Exam(DateTime startExam, int nemberOfQuestions, Question[] questions)
        {
            StartExam = startExam;
            NemberOfQuestions = nemberOfQuestions;
            Questions = questions;
        }
        public abstract void ShowExam();
    }
}
