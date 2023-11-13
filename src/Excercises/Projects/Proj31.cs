using static System.Net.Mime.MediaTypeNames;

namespace Exercises.Items
{
    public class Proj31 : BaseProj
    {
        public override string Description => "Write a C# program to multiply the corresponding elements of two integer arrays.";

        public override void Run()
        {
            int[] array1 = { 1, 3, -5, 4 };
            int[] array2 = { 1,4, -5, -2 };

            Console.WriteLine($"Array1: [{string.Join(", ", array1)}]");
            Console.WriteLine($"Array2: [{string.Join(", ", array2)}]");

            Console.WriteLine($"Multiply corresponding elements of two arrays: ");
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write($"{array1[i] * array2[i]} ");
            }
            Console.WriteLine("");
        }
    }
}
