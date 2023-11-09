using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj11: BaseProj
    {
        public override string Description => "Write a C# Sharp program that takes an age (for example 20) as input and prints something like \"You look older than 20\"."; 

        public override void Run()
        {
            var firstNum = GetNumber("Enter your age: ");
            

            Console.WriteLine($"You look older than {Math.Abs(firstNum)}");
           
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
