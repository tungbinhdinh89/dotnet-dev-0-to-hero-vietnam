using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj01 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to compute the sum of the two numerical values. If the two values are the same, return triple their sum.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
            int sum = num1 == num2 ? (num1 + num2) * 3 : num1 + num2;
            Console.WriteLine($"{sum}");

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
