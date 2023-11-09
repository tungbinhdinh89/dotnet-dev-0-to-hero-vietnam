using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj05: BaseProj
    {
        public override string Description => "Write a C# Sharp program to swap two numbers.";

        public override void Run()
        {
            var firstNum = GetNumber("Enter first number: ");
            var secondNum = GetNumber("Enter second number: ");
            Console.WriteLine($"Before: First Number = {firstNum}, Second number = {secondNum}");
            int temp;
            temp = firstNum;
            firstNum = secondNum;
            secondNum = temp;
            Console.WriteLine($"After: First Number = {firstNum}, Second number = {secondNum}");
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
