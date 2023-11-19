using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj22 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if a given string contains between 2 and 4 'z' characters.";
        public override void Run()
        {
            var str = GetString("Input your string");
           int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == 'z')
                {
                    num++;
                }
            }
            var result = (num >= 2 && num <=4 )  ? true : false;

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
