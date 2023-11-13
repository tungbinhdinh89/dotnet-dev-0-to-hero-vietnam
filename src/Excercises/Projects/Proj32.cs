namespace Exercises.Items
{
    public class Proj32 : BaseProj
    {
        public override string Description => "Write a C# program to create a string of four copies, taking the last four characters from a given string. If the given string is less than 4, return the original one.";

        public override void Run()
        {
            var str = GetString("Input your string: ");
            Console.WriteLine(GetNewString(str));

        }

        static string GetString(string msg)
        {
            Console.Write(msg);
            string str = Console.ReadLine();
            return str;
        }

        static string GetNewString(string str)
        {
            string newStr = str.Length < 4 ? str : str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4) + str.Substring(str.Length - 4);
            return newStr;
        }
    }
}
