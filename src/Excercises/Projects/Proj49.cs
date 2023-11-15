namespace Exercises.Items
{
    public class Proj49 : BaseProj
    {
        public override string Description => "Write a C# program to check if the first or the last element of the two arrays (length 1 or more) are equal.";
        public override void Run()
        {
            int[] arrNumber1 = { 1, 2, 8};
            int[] arrNumber2 = { 1, 2, 2, 3, 3, 4, 5, 6, 5, 7, 7, 7, 8, 8, 5 };
            Console.WriteLine($"Array1: {String.Join(", ", arrNumber1)} ");
            Console.WriteLine($"Array2: {String.Join(", ", arrNumber2)} ");
            Console.WriteLine($"Check: {arrNumber1[0] ==arrNumber2[0] || arrNumber1[arrNumber1.Length -1]== arrNumber2[arrNumber2.Length - 1]}");
        }
    }
}


