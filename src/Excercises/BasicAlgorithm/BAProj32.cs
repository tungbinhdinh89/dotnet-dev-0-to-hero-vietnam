namespace Exercises.Items
{
    public class BAProj32 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if a specified number is present in a given array of integers.";
        public override void Run()
        {
            bool CheckNumberInArr(int[]arrNumber, int number)
            {
                if(arrNumber.Contains(number)) return true; return false;
            }
            Console.WriteLine($"Sample Intput : {{ 1, 2, 9, 3 }}, 3");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 2, 9, 3 }, 3));
            Console.WriteLine($"Sample Intput : {{ 1, 2, 9, 3 }}, 4");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 2, 9, 3 }, 4));
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

            }
            while (true && num < 0);
            return num;
        }

    }
}
