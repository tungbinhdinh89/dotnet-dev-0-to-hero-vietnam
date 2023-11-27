namespace Exercises.Items
{
    public class DTProj04 : DataTypesProj
    {
        public override string Description => "Write a C# Sharp program that takes two numbers as input and performs an operation (+,-,*,x,/) on them and displays the result of that operation.";
        public override void Run()
        {
            var num1 = GetNumber("input first number");
            char operation;
            do
            {
                operation = GetChar("Input Operation");
            } while (operation != '+' || operation != '-');

            var num2 = GetNumber("input second number");

        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
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

    }
}
