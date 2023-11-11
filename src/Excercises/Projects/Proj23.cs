using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj23: BaseProj
    {
        public override string Description => "Write a C# program to convert a given string into lowercase."; 

        public override void Run()
        {
            var str = GetString("Input your strinng: ");

            Console.WriteLine(ToLowerCase(str)); 
        }

        static string GetString(string msg)
        {
           Console.WriteLine(msg);
            string str = Console.ReadLine();
            return str;
            
        }  

        static string ToLowerCase(string str)
        {
           return str.ToLower();
                
        }

    }
}
