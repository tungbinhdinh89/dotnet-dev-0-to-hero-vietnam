namespace Exercises.Items
{
    public class Proj51 : BaseProj
    {
        public override string Description => "Write a C# program to get the largest value between the first and last element of an array (length 3) of integers.\r\nTest Data:";
        public override void Run()
        {
            int[] arrNumber1 = { 1, 2, 5, 7, 8 };

            Console.WriteLine($"Array1: {String.Join(", ", arrNumber1)} ");
            Console.WriteLine($"Highest value between first and last values of the said array: {FindMaxNumberInArr(arrNumber1)}");
        }

        static int FindMaxNumberInArr(int[] arrayNumber)
        {
            int maxNumber = arrayNumber.Max();
            return maxNumber;
        }
    }
}


