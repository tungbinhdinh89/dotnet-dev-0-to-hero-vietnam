namespace Exercises.Items
{
    public class BAProj40 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to compute the sum of the two given integers. If the sum is in the range 10..20 inclusive return 30.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
            var sum = num1 + num2;
            var result = (sum >= 10 && sum <= 20) ? 30 : (num1 + num2);
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

        static char GetChar(string msg)
        {

            while (true)
            {
                Console.WriteLine(msg);
                var c = Console.ReadLine();
                if (c.Length < 2) return c[0];
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
