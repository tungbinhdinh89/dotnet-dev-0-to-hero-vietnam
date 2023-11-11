using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj22: BaseProj
    {
        public override string Description => "Write a C# program to check if the given integer is within 20 of 100 or 200."; 

        public override void Run()
        {
            var n = GetString("Input first integer: ");

            Console.WriteLine(Result(n));
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

        static bool Result(int n)
        {
           if (Math.Abs(n -100) <= 20 || Math.Abs(n -200) <= 20)
            {
                return true;
            }
            else
            {
                return false;
            } 
                
        }

    }
}
