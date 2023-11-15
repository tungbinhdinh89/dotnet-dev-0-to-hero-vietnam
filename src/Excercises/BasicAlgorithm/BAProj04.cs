using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj04 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check a given integer and return true if it is within 10 of 100 or 200.";
        public override void Run()
        {
            var num1 = GetNumber("Input your number");


            bool result = Math.Abs(num1 - 100) <= 10 || Math.Abs(num1 -200) <=10 ? true : false;
            Console.WriteLine(result);
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
