using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj04: BaseProj
    {
        public override string Description => "Write a C# Sharp program to print the results of the specified operations.";

        public override void Run()
        {
            var firstNum = GetNumber("Enter first number: ");
            var secondNum = GetNumber("Enter second number: ");

            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }
            }
        }
    }
}
