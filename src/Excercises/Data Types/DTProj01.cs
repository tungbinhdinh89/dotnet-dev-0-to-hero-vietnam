﻿namespace Exercises.Items
{
    public class DTProj01 : DataTypesProj
    {
        public override string Description => "Write a C# Sharp program that takes three letters and displays them in reverse order.";
        public override void Run()
        {
            var letter1 = GetChar("Input Letter 1");
            var letter2 = GetChar("Input Letter 2");
            var letter3 = GetChar("Input Letter 3");

            Console.WriteLine("{0} {1} {2}", letter3, letter2, letter1);
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

        static string GetString(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                return str;
            }
        }

        static char GetChar(string msg)
        {

            while (true)
            {
                Console.WriteLine(msg);
                var c = Console.ReadLine();
                if (c.Length < 2) return c[0];
            }
        }

    }
}
