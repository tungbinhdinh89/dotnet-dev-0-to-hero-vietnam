namespace Exercises.Items
{
    public class BAProj42 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to test if a given non-negative number is a multiple of 13 or one more than a multiple of 13.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");

            var result = (num1 % 13 == 0 || num1 % 13 ==1) ? true : false;
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
