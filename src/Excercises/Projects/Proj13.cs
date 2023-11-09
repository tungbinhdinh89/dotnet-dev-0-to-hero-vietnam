using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj13: BaseProj
    {
        public override string Description => "Write a C# program that takes a number as input and displays a rectangle of 3 columns wide and 5 rows tall using that digit."; 

        public override void Run()
        {
            var n = GetNumber("Enter your age: ");
            

            Console.WriteLine($"{n}{n}{n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n} {n}");
            Console.WriteLine($"{n}{n}{n}");



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
