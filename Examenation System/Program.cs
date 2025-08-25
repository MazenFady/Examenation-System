using Examenation_System.Type_of_Question;

namespace Examenation_System
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Subject subject = new Subject("101", "OOP");
            subject.CreatelExam();
            Console.WriteLine($"------------Examination Form------------\nSubject Name: {subject.SubjectName} \n Subject ID: {subject.SubjectID} ");
            subject.StartExam();
        }
    }
}
