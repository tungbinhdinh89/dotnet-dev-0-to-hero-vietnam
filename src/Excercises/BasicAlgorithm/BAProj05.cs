using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj05 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string where 'if' is added to the front of a given string. If the string already begins with 'if', return it unchanged.";
        public override void Run()
        {
            var str = GetString("Input your string");


            string newStr = str.Substring(0, 2) == "if" ? str : "if " + str;
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
    }
}
