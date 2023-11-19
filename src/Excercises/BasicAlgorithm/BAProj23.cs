namespace Exercises.Items
{
    public class BAProj23 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if two given non-negative integers have the same last digit.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
            var result = (Math.Abs(num1 % 10) == Math.Abs(num2 % 10)) ? true : false;

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
