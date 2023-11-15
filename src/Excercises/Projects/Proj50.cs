namespace Exercises.Items
{
    public class Proj50 : BaseProj
    {
        public override string Description => "Write a C# program to rotate an array (length 3) of integers in the left direction.";
        public override void Run()
        {
            int[] arrNumber1 = { 1, 2, 8 };

            Console.WriteLine($"Array1: {String.Join(", ", arrNumber1)} ");
            Console.WriteLine($"After rotating array becomes: {String.Join(", ", NewArr(arrNumber1))}");
        }

        static int[] NewArr(int[] arrayNumber)
        {
            List<int> newArr = new List<int>();
            for (int i = arrayNumber.Length - 1; i >= 0; i--)
            {
                newArr.Add(arrayNumber[i]);
            }
            return newArr.ToArray();
        }
    }
}


