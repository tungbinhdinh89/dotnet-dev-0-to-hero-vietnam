using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj08: BaseProj
    {
        public override string Description => "Write a C# Sharp program that prints the multiplication table of a number as input."; // 

        public override void Run()
        {
            var n = GetNumber("Enter the number: ");

            for (int i = 0; i <= 10;i++)
            {
                Console.WriteLine($"The table of number is : {n} * {i} = {n * i}");
            }
           
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }
            }
        }

       
    }
}
