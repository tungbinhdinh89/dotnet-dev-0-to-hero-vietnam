namespace Exercises.BasicAlgorithm
{
    public class BAProj57 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list from a given list of strings. Each element is replaced by 4 copies of the string concatenated together.";
        public override void Run()
        {
            //int[] arrNumber1 = { 1, 2, 3, 4 };
            string[] arrStr = { "1", "2", "3", "4" };


            Console.WriteLine($"Array1: {string.Join(", ", arrStr)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrStr))}");
        }

        static string[] NewArr(string[] arrStr)
        {
            var newArr = arrStr.Select(x => (x + x + x + x)).ToArray();
            return newArr;
        }
    }
}


