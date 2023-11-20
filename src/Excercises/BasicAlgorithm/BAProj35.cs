namespace Exercises.Items
{
    public class BAProj35 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to compare two given strings and return the number of positions where they contain the same length of 2 substrings.";
        public override void Run()
        {
            var str1 = GetString("Input your first string");
            var str2 = GetString("Input your second string");
            var count = 0;

            for (int i = 0; i < str1.Length - 1; i++)
            {
                for (int j = 0; j < str2.Length - 1; j++)
                {
                    if (str1.Substring(i, 2) == str2.Substring(j, 2)) count++;
                }
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
