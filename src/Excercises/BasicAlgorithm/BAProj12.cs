﻿using System;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class BAProj12 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if a given string starts with 'C#' or not.";
        public override void Run()
        {
            var str = GetString("Input your string");
            var result = (str.Substring(0,2) == "C#")?true :false;

            Console.WriteLine(result);
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

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if(int.TryParse(Console.ReadLine(), out int val) ) return val;
            }
        }
    }
}
