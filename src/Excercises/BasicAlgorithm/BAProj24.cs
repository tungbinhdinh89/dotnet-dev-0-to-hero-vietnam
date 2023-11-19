namespace Exercises.Items
{
    public class BAProj24 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to convert the last 3 characters of a given string to uppercase. If the length of the string is less than 3, then uppercase all the characters.";
        public override void Run() 
        {
            var str = GetString("Input your string");

            var result = (str.Length > 3) ? str.Substring(0, str.Length -3) +str.Substring(str.Length - 3, 3).ToUpper() : str.ToUpper();
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
                if (int.TryParse(Console.ReadLine(), out int val)) return val;
            }
        }
    }
}
