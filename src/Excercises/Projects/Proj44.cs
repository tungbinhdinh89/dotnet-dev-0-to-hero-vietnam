namespace Exercises.Items
{
    public class Proj44 : BaseProj
    {
        public override string Description => "Write a C# program to create a string of every other character (odd position) from the first position of a given string.";
        public override void Run()
        {
            var str = GetString("Input your string: ");
            Console.WriteLine($"The new String: {CheckString(str)}");
        }

        static string GetString(string msg)
        {
            string str;
            Console.Write(msg);
            str = Console.ReadLine();
            return str;
        }

        static string CheckString(string str)
        {
            string newStr="";
            for (int i = 0; i < str.Length; i++)
            {
                 if(i % 2 == 0) newStr += str[i];
            }
            return newStr;
        }
    }
}


