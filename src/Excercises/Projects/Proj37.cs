namespace Exercises.Items
{
    public class Proj37 : BaseProj
    {
        public override string Description => "Write a C# program to check if \"HP\" appears at the second position in a string and return the string without \"HP\".";
        static string Result = "Hello";
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
            if (str.Substring(1, 2).Equals("HP"))
            {
                Console.WriteLine($"String contain HP");
                newStr = str[0] + str.Substring(3);
            }
            else
            {
                Console.WriteLine($"String doesn't contain HP");

            }
            return newStr;
        }
    }
}

