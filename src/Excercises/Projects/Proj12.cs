using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj12: BaseProj
    {
        public override string Description => "Write a C# program that takes a number as input and displays it four times in a row (separated by blank spaces), and then four times in the next row, with no separation. You should do it twice: Use the console. Write and use {0}."; 

        public override void Run()
        {
            var n = GetNumber("Enter your num: ");

            Prinf(n);
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
        
        static void Prinf(int n)
        {
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine($"{n} {n} {n} {n}");
                Console.WriteLine($"{n}{n}{n}{n}");
            }    

        }

    }
}
