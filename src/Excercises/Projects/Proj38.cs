namespace Exercises.Items
{
    public class Proj38 : BaseProj
    {
        public override string Description => "Write a C# program to get a string of two characters from a given string. The first and second characters of the given string must be \"P\" and \"H\", so PHP will be \"PH\".";
        public override void Run()
        {
            string str = GetString("Input your string: ");
            Console.WriteLine(IsMatchWord(str));
        }

        static string GetString(string msg)
        {

            Console.Write(msg);
            string str = Console.ReadLine();
            return str;
        }

        static string IsMatchWord(string str)
        {
            string newStr = "";
            return newStr = str.StartsWith("PH")?str.Substring(0,2) : str;
        }
    }
}

