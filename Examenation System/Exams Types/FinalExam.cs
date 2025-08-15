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
        public FinalExam(int time,int nofq, Question[] questions)
        {
            bool flag = true;
            do
            {
                Console.WriteLine("Enter the Time of exam (From 30min To 180min) ");
            } while (!int.TryParse(Console.ReadLine(), out time) || time>=30 || time<=180);
            Console.WriteLine("\n----------------------------------------------------\n");
           
            do
            {
                Console.WriteLine("Enter the Number of questions : ");
            } while (!int.TryParse(Console.ReadLine(), out nofq) || nofq>0);
            Qustions= questions;
            for(int i = 0; i < questions.Length; i++)
            {
                Console.Write($"Enter the choice {i+1} : ");
                questions[i] = Console.ReadLine();
            }
        }

        public override void ShowExam()
        {
          
        }
        public void Read()
        {
           
        }
    }
}
