namespace Exercises.Items
{
    public class Proj33 : BaseProj
    {
        public override string Description => "Write a C# program to check if a given positive number is a multiple of 3 or 7.";

        public override void Run()
        {
            var num = GetNumber("Input your number: ");
            Console.WriteLine(IsMultipleOf3or7(num));

        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out int num))
                {
                    return num;
                }
            }
        }

        static bool IsMultipleOf3or7(int num)
        {
            return (num % 3 == 0 || num % 7 == 0) ? true : false;
        }
    }
}
