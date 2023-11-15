namespace Exercises.Items
{
    public class Proj45 : BaseProj
    {
        public override string Description => "Write a C# program to count a specified number in a given array of integers.";
        public override void Run()
        {
            int[] arrNumber = { 1, 2, 5, 2, 6, 7, 4, 5, 7, 7, 5, 7, 2, 5, 9, 8, 3 };
            var number = GetNumber("Input your number: ");
            //Console.WriteLine($"Number of {number} present in the said array: {CheckNumInArray(number,arrNumber)}");
            Console.WriteLine($"Number of {number} present in the said array: {arrNumber.Count(n => n == number)}");
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

        static int CheckNumInArray(int num, int[] arrayNumber)
        {
            int count = 0;
            foreach (var n in arrayNumber)
            {
                if (n == num) count++;
            }
            return count;
        }
    }
}


