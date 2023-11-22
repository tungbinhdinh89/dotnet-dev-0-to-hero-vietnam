namespace Exercises.BasicAlgorithm
{
    public class BAProj58 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list from a given list of strings. Each element has \"#\" added at the beginning and end position.";
        public override void Run()
        {
            //int[] arrNumber1 = { 1, 2, 3, 4 };
            string[] arrStr = { "1", "2", "3", "4" };


            Console.WriteLine($"Array1: {string.Join(", ", arrStr)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrStr))}");
        }

        static string[] NewArr(string[] arrStr)
        {
            var newArr = arrStr.Select(x => ("#" + x + "#")).ToArray();
            return newArr;
        }
    }
}


