using System;

namespace Exercises.Items
{
    public class Proj41 : BaseProj
    {
        public override string Description => "Write a C# program to check if a given string contains the 'w' character between 1 and 3 times.";
        static char c = 'w';
        public override void Run()
        {
            var str = GetString("Input your string: ");
            Console.WriteLine($"The string contains 'w' character between 1 and 3 times: {CheckString(str)}");
        }

        static string GetString(string msg)
        {
            string str;
            do
            {
                Console.Write(msg);
                str = Console.ReadLine();
                if (!str.Contains(c))
                {
                    Console.WriteLine($"string must contains at least one {c} char)");
                }
            }
            while (!str.Contains(c));

            return str;
        }

        static bool CheckString(string str)
        {
            bool checkString = false;
            int num = 0;
            for (int i = 0; i < str.Length; i++)
            {
                
                if (str[i] == c) num++;
            }

            if (num >= 1 && num <= 3)
            {
                return checkString = true;
            }
            return checkString;
        }
    }
}


