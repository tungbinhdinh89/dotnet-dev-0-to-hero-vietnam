namespace Exercises.Items
{
    public class Proj34 : BaseProj
    {
        public override string Description => "Write a C# program to check if a string starts with a specified word.";

        static string Result = "Hello";
        public override void Run()
        {
            var str = GetString("Input your string: ");
            Console.WriteLine(IsMatchWord(str));

        }

        static string GetString(string msg)
        {

            Console.Write(msg);
            string str = Console.ReadLine();
            return str;
        }

        static bool IsMatchWord(string str)
        {
            return ((str.Length < 6 && str.Equals(Result)) || (str.StartsWith(Result) && str[5] == ' ')) ? true : false;
        }
    }
}

