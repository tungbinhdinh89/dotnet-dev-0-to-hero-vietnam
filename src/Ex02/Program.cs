namespace Ex02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            Console.Write("Enter your number: ");
            var userInput = Console.ReadLine();
            isNum = int.TryParse(userInput, out num);
            Console.WriteLine($"{Math.Pow(num,2)}");
        }
    }
}
