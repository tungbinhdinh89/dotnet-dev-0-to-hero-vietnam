using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj10 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if a given positive number is a multiple of 3 or 7.";
        public override void Run()
        {
            var num = GetNumber("Input your number");
            var result = (num % 3 ==0 || num % 7 == 0)?true:false;

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
