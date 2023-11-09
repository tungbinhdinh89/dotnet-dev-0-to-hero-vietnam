using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj10: BaseProj
    {
        public override string Description => "Write a C# Sharp program that takes three numbers (x,y,z) as input and outputs (x+y).z and x.y + y.z."; 

        public override void Run()
        {
            var firstNum = GetNumber("Enter the first number: ");
            var secondNum = GetNumber("Enter the second number: ");
            var thirdNum = GetNumber("Enter the third number: ");

            Console.WriteLine($"Result of specified numbers {firstNum}, {secondNum}, and {thirdNum}, (x+y).z is {(firstNum + secondNum) * thirdNum} and x.y + y.z is {firstNum * secondNum + secondNum * thirdNum}");
           
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
