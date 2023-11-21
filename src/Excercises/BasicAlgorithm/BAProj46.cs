namespace Exercises.Items
{
    public class BAProj46 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check whether a given string begins with \"F\" or ends with \"B\". If the string starts with \"F\" return \"Fizz\" and return \"Buzz\" if it ends with \"B\" If the string starts with \"F\" and ends with \"B\" return \"FizzBuzz\". In other cases return the original string.";
        public override void Run()
        {
            var str = GetString("Input your string");
            var newStr = "";
            if (str[0] == 'F' && str[str.Length - 1] == 'B') newStr = "FizzBuzz";
            else if (str[str.Length - 1] == 'B') newStr = "Buzz";
            else if (str[0] == 'F' ) newStr = "Fizz";
            else newStr = str;


            Console.WriteLine(newStr);
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
