using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj07 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to exchange the first and last characters in a given string and return the new string.";
        public override void Run()
        {
            var str = GetString("Input your string");
            var result = str.Length > 1? str[str.Length - 1] + str.Substring(1, str.Length -2) + str[0] : str;

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
