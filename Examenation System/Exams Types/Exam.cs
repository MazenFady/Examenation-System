using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Exams_Types
{
    public abstract class Exam
    {
        private int Time { get; set; }
        private int NumberOfQustion { get; set; }
        public Question[] Qustions { get; set; }

        public int GetTime()
        {
            return this.Time;
        }
        public void SetTime(int time)
        {
            this.Time = time;
        }
        public abstract void ShowExam();

    }
}
