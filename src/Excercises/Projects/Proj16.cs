using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj16: BaseProj
    {
        public override string Description => "Write a C# program to create a new string from a given string where the first and last characters change their positions."; 

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
            return str.Length > 1 ? str.Substring(str.Length - 1) + str.Substring(1, str.Length - 2) + str.Substring(0, 1) : str;
        }
    }
}
