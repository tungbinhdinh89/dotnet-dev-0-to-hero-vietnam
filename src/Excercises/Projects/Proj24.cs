using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises.Items
{
    public class Proj24: BaseProj
    {
        public override string Description => "Write a C# program to find the longest word in a string."; 

        public override void Run()
        {
            var str = GetString("Input your strinng: ");

            string[] word = str.Split(new [] {" "}, StringSplitOptions.None);
            Console.WriteLine(FindLongestWord(word));
        }

        static string GetString(string msg)
        {
           Console.WriteLine(msg);
            string str = Console.ReadLine();
            return str;
            
        }

        static string FindLongestWord(string[] str)
        {
            string longestWord = "aaa";
            for (int i = 0; i < str.Length; i++)
            {
                if (longestWord.Length < str[i].Length) 
                {
                longestWord = str[i];
                }  
            }
            return longestWord;

        }

    }
}
