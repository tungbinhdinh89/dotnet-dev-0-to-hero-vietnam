namespace Exercises.Items
{
    public class BAProj31 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to count a substring of length 2 that appears in a given string. This substring appears as the last 2 characters of the string. Do not count the end substring.";
        public override void Run()
        {
            var str = GetString("Input your string");
            int count = -1;

            for (int i = 0; i < str.Length -1; i++)
            {
                if (str.Substring(i, 2) == str.Substring(str.Length - 2)) count++;
                
            }

            Console.WriteLine(count);
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
            int num;
            do
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out num)) ;

            }
            while (true && num < 0);
            return num;
        }
    }
}
