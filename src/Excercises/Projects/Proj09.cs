using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj09: BaseProj
    {
        public override string Description => "Write a C# Sharp program that takes four numbers as input to calculate and print the average."; 

        public override void Run()
        {
            var firstNum = GetNumber("Enter the first number: ");
            var secondNum = GetNumber("Enter the second number: ");
            var thirdNum = GetNumber("Enter the third number: ");
            var fourNum = GetNumber("Enter the four number: ");

            Console.WriteLine($"The average of {firstNum}, {secondNum}, {thirdNum}, {fourNum} is {(firstNum + secondNum + thirdNum + fourNum)/ 4}");
           
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
