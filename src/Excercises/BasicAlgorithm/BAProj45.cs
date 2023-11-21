namespace Exercises.Items
{
    public class BAProj45 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to compute the sum of the two given integers. Return 18 if one of the given integer values is in the range of 10..20 inclusive.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");


            var result = (num1 >=10 && num1 <=20 || num2 >=10 && num2 <=20) ? 18 : num1+ num2;
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
