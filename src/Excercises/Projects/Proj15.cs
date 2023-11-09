using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj15: BaseProj
    {
        public override string Description => "Write a C# program that removes a specified character from a non-empty string using the index of a character."; 

        public override void Run()
        {
            var str = GetString("Input your string: ");

            Console.WriteLine($"{RemoveChar(str,1)}");
            Console.WriteLine($"{RemoveChar(str, 9)}");
            Console.WriteLine($"{RemoveChar(str, 0)}");

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
            while (str.Length > 2);
        }  

        static string RemoveChar (string str, int n) { 
        return str.Remove(n, 1);
        }
    }
}
