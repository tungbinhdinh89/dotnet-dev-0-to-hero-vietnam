using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj06: BaseProj
    {
        public override string Description => "Write a C# Sharp program to print the output of the multiplication of three numbers entered by the user.";

        public override void Run()
        {
            var firstNum = GetNumber("Enter first number: ");
            var secondNum = GetNumber("Enter second number: ");
            var thirdNum = GetNumber("Enter third number: ");

            Console.WriteLine($"{firstNum} * {secondNum} * {thirdNum} = {firstNum * secondNum * thirdNum}");
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
