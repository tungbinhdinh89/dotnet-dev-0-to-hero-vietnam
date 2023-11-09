using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj18: BaseProj
    {
        public override string Description => "Write a C# program to check a pair of integers and return true if one is negative and one is positive."; 

        public override void Run()
        {
            var n1 = GetString("Input first integer: ");
            var n2 = GetString("Input second integer: ");
            
            Console.WriteLine(n1 > 0 && n2 <0 || n1 > 0 && n2 < 0);
        }

        static int GetString(string msg)
        {
           while (true)
            {
                Console.WriteLine(msg); 
                if(int.TryParse(Console.ReadLine(), out int n))
                {
                    return n;
                }
            }
        }  
    }
}
