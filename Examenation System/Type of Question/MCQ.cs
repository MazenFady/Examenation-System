using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Type_of_Question
{
    internal class MCQ : Question
    {
        public MCQ(string header, string body, float mark, Answer[] answers, int rightIndex)
         : base(header, body, mark)
        {
            ListAnswer = answers ?? Array.Empty<Answer>();
            RightAnswer = rightIndex;
        }
        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            if (ListAnswer != null)
            {
                for (int i = 0; i < ListAnswer.Length; i++)
                    Console.WriteLine($"  {i}. {ListAnswer[i].AnswerText}");
            }
        }
        //public MCQ()
        //{
        //    Console.WriteLine("MCQ qustion : ");
        //    Console.WriteLine("--------------------");

        //    Console.Write("Enter the qustion : ");
        //    string qustion =Console.ReadLine();

        //    Console.WriteLine();
        //    float mark;
        //    do
        //    {
        //        Console.Write("Enter Mark of this qustion : ");
        //    } while (!float.TryParse(Console.ReadLine(), out mark) && mark>-1);

        //}
    }
}
