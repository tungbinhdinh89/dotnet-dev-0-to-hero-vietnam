using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj06 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to remove the character at a given position in the string. The given position will be in the range 0..(string length -1) inclusive.";
        public override void Run()
        {
            var str = GetString("Input your string");
            var num = GetNumber("Input your number");
            var result = str.Remove(num,1);

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
