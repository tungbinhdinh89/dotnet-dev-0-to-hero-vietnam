using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj21: BaseProj
    {
        public override string Description => "Write a C# program to check the sum of the two given integers. Return true if one of the integers is 20 or if their sum is 20."; 

        public override void Run()
        {
            var n1 = GetString("Input first integer: ");
            var n2 = GetString("Input second integer: ");
            
            Console.WriteLine(n1 > 20 || n2 > 20 || n1 + n2 > 20);
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

        static int Result(int a, int b)
        {
            if (a > b)
            {
                return (a - b) + (a -b);
            }
            else
            {
                return Math.Abs(a - b);
            }
        }

    }
}
