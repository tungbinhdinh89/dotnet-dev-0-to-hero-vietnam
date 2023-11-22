namespace Exercises.BasicAlgorithm
{
    public class BAProj59 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list from a given list of integers. Each integer is multiplied by itself three times.";
        public override void Run()
        {
            int[] arrNumber1 = { 1, 2, 3, 4 };
            //string[] arrStr = { "Abc", "cdef", "js", "php" };


            Console.WriteLine($"Array1: {string.Join(", ", arrNumber1)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrNumber1))}");
        }

        static int[] NewArr(int[] arrStr)
        {
            var newArr = arrStr.Select(x => (x)*3).ToArray();
            return newArr;
        }
    }
}


