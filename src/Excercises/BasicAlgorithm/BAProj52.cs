namespace Exercises.BasicAlgorithm
{
    public class BAProj52 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list from a given list of integers removing those values less than 4";
        public override void Run()
        {
            int[] arrNumber1 = { 0, -2, 1, 2, 3, 5, 4, 7, 8 };

            Console.WriteLine($"Array1: {string.Join(", ", arrNumber1)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrNumber1))}");
        }

        static int[] NewArr(int[] arrayNumber)
        {
            
        var newArr = arrayNumber.Where(x => x <4);
            return newArr.ToArray();
        }
    }
}


