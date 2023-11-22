namespace Exercises.BasicAlgorithm
{
    public class BAProj55 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list of the rightmost digits from a given list of positive integers.";
        public override void Run()
        {
            int[] arrNumber1 = { 10, 22, 35, 41 };
            //string[] arrStr = { "Abc", "cdef", "js", "php" };


            Console.WriteLine($"Array1: {string.Join(", ", arrNumber1)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrNumber1))}");
        }

        static int[] NewArr(int[] arrStr)
        {
                       var newArr = arrStr.Select(x => x % 10).ToArray();
            return newArr;
        }
    }
}


