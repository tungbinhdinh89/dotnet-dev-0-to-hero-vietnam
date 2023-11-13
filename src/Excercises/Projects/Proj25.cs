namespace Exercises.Items
{
    public class Proj25 : BaseProj
    {
        public override string Description => "Write a C# program to print odd numbers from 1 to 99. Prints one number per line.";

        public override void Run()
        {
            var n = GetNumber("Input your number: ");
            OddNumber(n);

        }

        static int GetNumber(string msg)
        {

            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }

            }
        }

        static void OddNumber(int n)
        {
            for (int i = 0; i < n; i++)
            {
                if(i % 2 != 0)
                {
                    Console.WriteLine(i);
                }
            }
        }

    }
}
