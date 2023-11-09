using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj07: BaseProj
    {
        public override string Description => "Write a C# Sharp program to print on screen the output of adding, subtracting, multiplying and dividing two numbers entered by the user.";

        public override void Run()
        {
            var firstNum = GetNumber("Enter first number: ");
            var secondNum = GetNumber("Enter second number: ");
          
            Console.WriteLine($"{firstNum} + {secondNum} = {firstNum + secondNum}");
            Console.WriteLine($"{firstNum} - {secondNum} = {firstNum - secondNum}");
            Console.WriteLine($"{firstNum} * {secondNum} = {firstNum * secondNum}");
            Console.WriteLine($"{firstNum} / {secondNum} = {firstNum / secondNum}");
            Console.WriteLine($"{firstNum} mod {secondNum} = {firstNum % secondNum}");
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
