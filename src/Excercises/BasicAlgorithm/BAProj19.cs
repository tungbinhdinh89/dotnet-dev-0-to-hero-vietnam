using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj19 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check which number is closest to 100 among two given integers. Return 0 if the two numbers are equal.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
           ;

            var max = (num1 == num2) ? 0 : ((100 - num1 > 100 -num2?num2:num1));

            Console.WriteLine(max);
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
