namespace Exercises.Items
{
    public class BAProj34 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check whether the sequence of numbers 1, 2, 3 appears in a given array of integers somewhere.";
        public override void Run()
        {
            bool CheckNumberInArr(int[] arrNumber)
            {
                for (int i = 0; i < arrNumber.Length -1; i++)
                {
                    if (arrNumber[i] == 1 && arrNumber[i+1] == 2 && arrNumber[i+2] == 3) return true;
                }
                return false;
            }
            Console.WriteLine($"Sample Intput : {{ 1, 1, 2, 3, 1 }}");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 1, 2, 3, 1 }));
            Console.WriteLine($"Sample Intput : {{ 1, 1, 2, 4, 1 }}");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 1, 2, 4, 1 }));
            Console.WriteLine($"Sample Intput : {{ 1, 1, 2, 1, 2, 3 }}");
            Console.WriteLine(CheckNumberInArr(new[] { 1, 1, 2, 1, 2, 3 }));
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
