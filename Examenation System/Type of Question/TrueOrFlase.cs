using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examenation_System.Type_of_Question
{
    internal class TrueOrFlase : Question
    {
        public TrueOrFlase(string header, string body, float mark, bool correctTrue)
            : base(header, body, mark)
        {
            ListAnswer = new Answer[]
            {
                new Answer(0, "False"),
                new Answer(1, "True")
            };
            RightAnswer = correctTrue ? 1 : 0;
        }

        public override void ShowQuestion()
        {
            Console.WriteLine(Header);
            Console.WriteLine(Body);
            Console.WriteLine("  0. False");
            Console.WriteLine("  1. True");
        }
    }
}
