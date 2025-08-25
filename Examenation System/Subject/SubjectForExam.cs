using Examenation_System.Exams_Types;
using Examenation_System.Type_of_Question;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System
{
    public class Subject
    {
        public string? SubjectID { get; set; }
        public string? SubjectName { get; set; }
        public Exam? Exam { get; set; }
        public Subject(string? subjectID, string? subjectName)
        {
            SubjectID = subjectID;
            SubjectName = subjectName;
        }

        public void CreatelExam()
        {
            string type = "";
            do
            {
                Console.Write("Choose type of exam [ a) Practical | b) Final ]: ");
                type = Console.ReadLine()?.ToLower();
                if (string.IsNullOrWhiteSpace(type) || type[0] != 'a' && type[0] != 'b')
                {
                    Console.Write("Wrong choice! ");
                    type = "";
                }

            } while (string.IsNullOrWhiteSpace(type));

            Console.WriteLine("---------------------------------------------------------");
            float ExamTime;
            do
            {
                Console.Write("Determine time of the exam in the range (30 : 180 minutes): ");
            }
            while (!float.TryParse(Console.ReadLine(), out ExamTime) || ExamTime < 30 || ExamTime > 180);


            Console.WriteLine("---------------------------------------------------------");

            int NumQustions = 0;
            do
            {
                Console.Write("Enter The number of qustions: ");
            } while (!int.TryParse(Console.ReadLine(), out NumQustions));

            Console.Clear();

            Question[] questions = new Question[NumQustions];
            if (type[0] == 'a')
            {
                for (int i = 0; i < NumQustions; i++)
                {
                    questions[i] = new MCQ("", "", 0, new Answer[3], null).CreateMCQQustion(i + 1);
                }
                Exam = new PracticalExam(DateTime.Now, NumQustions, questions);
            }
            else
            {
                for (int i = 0; i < NumQustions; i++)
                {
                    Console.Write($"Choose type of Question '{i + 1}' [ a) MCQ | b) True/False ]: ");
                    string qType = Console.ReadLine()?.ToLower();
                    if (!string.IsNullOrWhiteSpace(qType) && qType[0] == 'a')
                    {
                        questions[i] = new MCQ("", "", 0, new Answer[3], null).CreateMCQQustion(i + 1);
                    }
                    else
                    {
                        questions[i] = TrueOrFlase.CreateTFQuestion(i + 1);
                    }
                    Console.Clear();
                }
                Exam = new FinalExam(DateTime.Now, NumQustions, questions);
            }
        }

        public void StartExam()
        {
            string start = "";
            do
            {
                Console.Write("Do You want start exam ? [ a)Yes - b)No ]");
                start = Console.ReadLine()?.ToLower();
                if (string.IsNullOrWhiteSpace(start) || start[0] != 'a' && start[0] != 'b')
                {
                    Console.Write("wrong Choice! ");
                    start = "";
                }
            } while (string.IsNullOrWhiteSpace(start) || start[0] != 'a' && start[0] != 'b');
            Console.WriteLine();
            if (start[0] == 'b')
            {
                Console.WriteLine("Exam cancelled..Thank you ^_^");
                return;
            }
            Console.Clear();
            Console.WriteLine("Exam started now..!\n");
            Exam.StartExam = DateTime.Now;
            float totalGrade = 0;
            float studentGrade = 0;

            for (int i = 0; i < Exam.NemberOfQuestions; i++)
            {
                var q = Exam.Questions[i];
                Console.WriteLine($"\nQ{i + 1}) {q.BodyOfQusetion}   (Mark: {q.Mark})");

                foreach (var ans in q.AnswersList)
                {
                    Console.WriteLine($"{ans.AnswerID}) {ans.AnswerText}");
                }

                Console.Write("Enter your answer: ");
                int userChoice;
                while (!int.TryParse(Console.ReadLine(), out userChoice) ||
                       userChoice < 1 || userChoice > q.AnswersList.Length)
                {
                    Console.Write("Invalid choice, try again: ");
                }

                q.UserAnswer = q.AnswersList[userChoice - 1];

                totalGrade += q.Mark;
                if (q.UserAnswer.AnswerID == q.RightAnswer.AnswerID)
                {
                    studentGrade += q.Mark;
                }
            }

            DateTime endExam = DateTime.Now;
            TimeSpan duration = endExam - Exam.StartExam;
        }
    }
}
