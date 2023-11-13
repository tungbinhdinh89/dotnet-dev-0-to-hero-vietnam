namespace Exercises.Items
{
    public class Proj39 : BaseProj
    {
        public override string Description => "Write a C# program to find the largest and lowest values from three integer values.";
        public override void Run()
        {
            var n1 = GetNumber("Input your first number: ");
            var n2 = GetNumber("Input your second number: ");
            var n3 = GetNumber("Input your third number: ");

            Console.WriteLine($"Largest of three: {Math.Max(n1,Math.Max(n2,n3))}");
            Console.WriteLine($"Lowest of three: {Math.Min(n1, Math.Min(n2, n3))}");
        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }
            }
        }
    }
}

