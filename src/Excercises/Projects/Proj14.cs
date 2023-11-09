using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj14: BaseProj
    {
        public override string Description => "Write a C# program to convert Celsius degrees to Kelvin and Fahrenheit."; 

        public override void Run()
        {
            var celsius = GetNumber("Enter the amount of celsius: ");

            Console.WriteLine($"Kelvin: {celsius + 273.15}");
            Console.WriteLine($"Fahrenheit : {celsius * 9/5 + 32}");
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
