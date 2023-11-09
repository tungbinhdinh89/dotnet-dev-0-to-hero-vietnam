using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj19: BaseProj
    {
        public override string Description => "Write a C# program to compute the sum of two given integers. If two values are the same, return the triple of their sum."; 

        public override void Run()
        {
            var n1 = GetString("Input first integer: ");
            var n2 = GetString("Input second integer: ");
            
            Console.WriteLine(Result(n1,n2));
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
            if (a == b)
            {
                return (a + b) * 3;
            }
            else
            {
                return a + b;
            }
        }

    }
}
