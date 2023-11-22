namespace Exercises.BasicAlgorithm
{
    public class BAProj51 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list from a given list of integers, removing all values ending in 7.";
        public override void Run()
        {
            int[] arrNumber1 = { 10, 22, 35, 47, 53, 67 };

            Console.WriteLine($"Array1: {string.Join(", ", arrNumber1)} ");

            //for ( int i = 0; i < arrNumber1.Length; i++)
            //{
            //    if (arrNumber1[i] % 10 !=7)
            //    {

            //    }
            //}


            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrNumber1))}");
        }

        static int[] NewArr(int[] arrayNumber)
        {
            //List<int> newArr = new List<int>();
            //for (int i = arrayNumber.Length - 1; i >= 0; i--)
            //{
            //    newArr.Add(arrayNumber[i]);
            //}
            //return newArr.ToArray();

            var newArr = arrayNumber.Where(x => x % 10 != 7);
            return newArr.ToArray();
        }
    }
}


