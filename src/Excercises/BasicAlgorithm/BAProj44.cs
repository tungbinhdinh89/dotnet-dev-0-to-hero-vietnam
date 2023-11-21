namespace Exercises.Items
{
    public class BAProj44 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if a given number is within 2 of a multiple of 10.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");

            var result = (num1 % 10 <= 2 || num1 % 10 >= 8) ? true : false;
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
