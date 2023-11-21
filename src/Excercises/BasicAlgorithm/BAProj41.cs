namespace Exercises.Items
{
    public class BAProj41 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program that accepts two integers and returns true if either is 5 or their sum or difference is 5.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
            var sum = num1 + num2;
            var difference = Math.Abs(num1 - num2);

            var result = ((num1 == 5 || num2 ==5) || sum ==5 || difference ==5) ? true : false;
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
