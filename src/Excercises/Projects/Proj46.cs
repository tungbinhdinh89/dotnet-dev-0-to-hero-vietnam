namespace Exercises.Items
{
    public class Proj46 : BaseProj
    {
        public override string Description => "Write a C# program to check if a number appears as the first or last element of an array of integers. The array length is 1 or more.";
        public override void Run()
        {
            int[] arrNumber = { 1, 2, 5, 2, 6, 7, 4, 5, 7, 7, 5, 7, 2, 5, 9, 8, 3 };
            var number = GetNumber("Input your number: ");
            //Console.WriteLine($"Number of {number} present in the said array: {CheckNumInArray(number,arrNumber)}");
            Console.WriteLine($"Check: {CheckNumInArray(number, arrNumber)}");
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

        static bool CheckNumInArray(int num, int[] arrayNumber)
        {
            if (arrayNumber[0] == num || arrayNumber[arrayNumber.Length - 1] == num) return true;
            return false;
        }
    }
}


