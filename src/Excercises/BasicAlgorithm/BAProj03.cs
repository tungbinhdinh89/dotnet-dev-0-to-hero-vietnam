using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj03 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check two given integers, and return true if one of them is 30 or if their sum is 30.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");

            bool result = (num1 == 30 || num2 == 30 || num1 + num2 == 30) ? true : false;
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
