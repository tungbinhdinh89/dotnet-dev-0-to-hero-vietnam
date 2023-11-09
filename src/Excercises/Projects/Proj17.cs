using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj17: BaseProj
    {
        public override string Description => "Write a C# program to create a string from a given string (length 1 or more) with the first character added at the front and back."; 

        public override void Run()
        {
            var str = GetString("Input your string: ");

            Console.WriteLine($"{NewString(str)}");
        }

        static string GetString(string msg)
        {
            string str;
            do
            {
                Console.Write(msg);
                str = Console.ReadLine();
                return str;
            }
            while (str.Length > 1);
        }  

        static string NewString (string str) {
            return str.Length > 1 ? str.Substring(0,1) + str + str.Substring(0,1) : str;
        }
    }
}
