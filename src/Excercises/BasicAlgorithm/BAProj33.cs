namespace Exercises.Items
{
    public class BAProj33 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if one of the first 4 elements in an array of integers is equal to a given element.";
        public override void Run()
        {
            bool CheckNumberInArr(int[] arrNumber, int number)
            {
                bool result = false;
                for (int i = 0; i < 4; i++)
                {
                    if (arrNumber[i] == number) return true;
                }
                return result;
            }
            Console.WriteLine($"Sample Intput : {{ 1, 2, 9, 3,8 }}, 8");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 2, 9, 3,8 }, 8));
            Console.WriteLine($"Sample Intput : {{ 1, 2, 9, 3 }}, 4");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 2, 9, 3 }, 4));
            Console.WriteLine($"Sample Intput : {{ 1, 2, 9, 3 }}, 3");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 2, 9, 3 }, 3));
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
