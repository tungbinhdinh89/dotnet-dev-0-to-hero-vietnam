namespace Ex03
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1;
            int num2;
            bool isNum;
            Console.WriteLine("Input first number: ");
            var n1 = Console.ReadLine();
            Console.WriteLine("Input second number: ");
            var n2 = Console.ReadLine();
            isNum = int.TryParse(n1, out num1);
            isNum = int.TryParse(n2, out num2);
            Console.WriteLine($"Sum of number 1 and number 2: {Sum(num1, num2)}");

            int Sum(int a, int b)
            {
                return a + b;
            }
        }


    }
}
