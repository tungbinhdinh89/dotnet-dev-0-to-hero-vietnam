namespace Exercises.BasicAlgorithm
{
    public class BAProj54 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a list from a given list of strings. Strings will be in upper case in the new string.";
        public override void Run()
        {
            //int[] arrNumber1 = { 0, -2, 1, 2, 3, 5, 4, 7, 8 };
            string[] arrStr = { "Abc", "cdef", "js", "php" };


            Console.WriteLine($"Array1: {string.Join(", ", arrStr)} ");
            Console.WriteLine($"After rotating array becomes: {string.Join(", ", NewArr(arrStr))}");
        }

        static string[] NewArr(string[] arrStr)
        {
            string[] newArr = new string[] { };
            newArr = arrStr.Select(x => x.ToUpper()).ToArray();
            return newArr;
        }
    }
}


