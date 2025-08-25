using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Type_of_Question
{
    internal class MCQ : Question
    {
        public MCQ(string headerOfQusetion, string bodyOfQusetion, float mark, Answer[] answersList, Answer rightAnswer) 
        : base(headerOfQusetion, bodyOfQusetion, mark, answersList, rightAnswer)
        {
        }
        public MCQ CreateMCQQustion(int qNum)
        {
            Console.WriteLine($"--------Qustion {qNum} - (MCQ)--------");
            string body = "";
            do
            {
                Console.WriteLine("Qustion body : ");
                body = Console.ReadLine();
            } while (string.IsNullOrWhiteSpace(body));
            Console.WriteLine("------------------------");
            Answer[] answers = new Answer[3];
            for (int i = 0; i < 3; i++)
            {
                string text = "";
                do
                {
                    Console.Write($"Enter choice {i + 1} : ");
                    text = Console.ReadLine();
                } while (string.IsNullOrWhiteSpace(text));
                answers[i] = new Answer(i + 1, text);
                Console.WriteLine();
            }
            Console.Write("Number of right answer: ");
            int correctIndex;
            while (!int.TryParse(Console.ReadLine(), out correctIndex) || correctIndex < 1 || correctIndex > 3) ;
            Answer rightAnswer = answers[correctIndex - 1];

            float mark;
            do
            {
                Console.Write("Mark of qustion = ");
            } while (!float.TryParse(Console.ReadLine(), out mark) || mark < 0);
            return new MCQ("MCQ", body, mark, answers, rightAnswer);
        }
        public override void ShowQustion()
        {
            Console.Write($"{HeaderOfQusetion}: {BodyOfQusetion}   (Mark: {Mark})");
            foreach (var ans in AnswersList)
                Console.WriteLine($"{ans.AnswerID}) {ans.AnswerText}");
        }
    }
}
