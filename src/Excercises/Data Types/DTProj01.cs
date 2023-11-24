namespace Exercises.Items
{
    public class DTProj01 : DataTypesProj
    {
        public override string Description => "Write a C# Sharp program that takes three letters and displays them in reverse order.";
        public override void Run()
        {
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

    }
}
