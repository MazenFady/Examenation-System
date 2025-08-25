using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Type_of_Question
{
    internal class TrueOrFlase : Question
    {
        public TrueOrFlase(string headerOfQusetion, string bodyOfQusetion, float mark, Answer[] answersList, Answer rightAnswer)
        : base(headerOfQusetion, bodyOfQusetion, mark, answersList, rightAnswer)
        {
        }
        public static TrueOrFlase CreateTFQuestion(int qNum)
        {
            Console.WriteLine($"--- Question {qNum} (True||False) ---");

            Console.Write("Question body: ");
            string? body = Console.ReadLine();

            float mark;
            do
            {
                Console.Write("Enter mark of question: ");

            } while (!float.TryParse(Console.ReadLine(), out mark) || mark < 0);

            Answer[] answers =
            {
                new Answer(1, "True"),
                new Answer(2, "False")
            };

            int correctIndex;
            do
            {
                Console.Write("Enter number of correct answer [ 1)True | 2)False ]: ");
            } while (!int.TryParse(Console.ReadLine(), out correctIndex) || correctIndex < 1 || correctIndex > 2);

            Answer rightAnswer = answers[correctIndex - 1];

            return new TrueOrFlase("True/False", body, mark, answers, rightAnswer);
        }

        public override void ShowQustion()
        {
            Console.WriteLine($"{HeaderOfQusetion}: {BodyOfQusetion}  (Mark: {Mark})");
            foreach (var ans in AnswersList)
            {
                Console.WriteLine($"{ans.AnswerID}. {ans.AnswerText}");
            }
        }
    }
}
