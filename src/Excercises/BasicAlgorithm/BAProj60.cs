namespace Exercises.BasicAlgorithm
{
    public class BAProj60 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create an array of given length using odd numbers from a given array of positive integers.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            //string[] arrStr = { "Abc", "cdef", "js", "php" };
            Console.WriteLine(CheckNumber(num1));
            

        }

        static bool CheckNumber(int number)
        {
            while (number > 0)
            {
                if (number % 10 == 2) return true;
                number /= 10;
            }
            return false;
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out int val)) return val;
            }
        }
    }
}


