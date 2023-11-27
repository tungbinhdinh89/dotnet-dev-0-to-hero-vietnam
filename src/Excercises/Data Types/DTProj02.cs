namespace Exercises.Items
{
    public class DTProj02 : DataTypesProj
    {
        public override string Description => "Write a C# Sharp program that takes a number and a width also a number. It then displays a triangle of that width using that number.";
        public override void Run()
        {
            var number = GetNumber("Input a number: ");
            var width = GetNumber("Input the desired width: ");

            int height = width;
            for (int i = 0; i < height; i++)
            {
                for (int j = 0; j < width; j++)
                {
                    Console.Write(number);
                }
                Console.WriteLine();
                width--;
            }
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
