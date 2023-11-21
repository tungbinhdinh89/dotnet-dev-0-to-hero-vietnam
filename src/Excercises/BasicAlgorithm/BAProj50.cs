namespace Exercises.Items
{
    public class BAProj50 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if two or more integers that are not negative have the same rightmost digit.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
            var num3 = GetNumber("Input your third number");

            var result = (num1 % 10 == num2 % 10 || num1 % 10 == num3 % 10 || num2 % 10 == num3 % 10) ? true : false;

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
            int num;
            do
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out num)) ;
                return num;

            }
            while (true);

        }
    }
}
