namespace Exercises.BasicAlgorithm
{
    public class BAProj53 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to remove all \"a\"s from each string in a given list of strings and return the result string.";
        public override void Run()
        {
            //int[] arrNumber1 = { 0, -2, 1, 2, 3, 5, 4, 7, 8 };
            string[] arrStr = { "abc", "cdaef", "js", "php" };


            Console.WriteLine($"Array1: {string.Join(", ", arrStr)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrStr))}");
        }

        static string[] NewArr(string[] arrStr)
        {
            var newArr = arrStr.Select(x => x.Replace("a", "")).ToArray();
            return newArr;
        }
    }
}


