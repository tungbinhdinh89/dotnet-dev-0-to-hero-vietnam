namespace Exercises.Items
{
    public class Proj47 : BaseProj
    {
        public override string Description => "Write a C# program to compute the sum of all the elements of an array of integers.";
        public override void Run()
        {
            int[] arrNumber = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 1 };
            Console.WriteLine($"Array1: {String.Join(", ", arrNumber)} ");
            Console.WriteLine($"Sum: {SumNumberInArray(arrNumber)}");
        }

        static int SumNumberInArray(int[] arrayNumber)
        {
            int sum = 0;
            foreach (var number in arrayNumber)
            {
                sum += number;
            }
            return sum;
        }
    }
}


