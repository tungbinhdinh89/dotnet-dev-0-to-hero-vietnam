using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj09 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string with the last char added at the front and back of a given string of length 1 or more.";
        public override void Run()
        {
            var str = GetString("Input your string");
            var newStr = str[str.Length - 1] + str + str[str.Length - 1];

            Console.WriteLine(newStr);
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
