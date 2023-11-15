using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj02 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to get the absolute difference between n and 51. If n is broader than 51 return triple the absolute difference.";
        public override void Run()
        {
            var num = GetNumber("Input your  number");
            int result = num > 51? Math.Abs(num - 51)*3:Math.Abs(num - 51);
            Console.WriteLine(result);
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }
    }
}
