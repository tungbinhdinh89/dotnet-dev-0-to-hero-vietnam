using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj21 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to find the largest value from two positive integer values in the range 20..30 inclusive. Return 0 if neither is in that range.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
           ;

            var result = ((num1 >= 20 && num1 <= 30) && (num1 >= 20 && num1 <= 30)) ?(Math.Max(num1,num2)) : 0;

            Console.WriteLine(result);
        }

        static string GetString(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                return str;
            }
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if(int.TryParse(Console.ReadLine(), out int val) ) return val;
            }
        }
    }
}
