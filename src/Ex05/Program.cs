namespace Ex05
{
    internal class Program
    {
        static void Main(string[] args)
        {

            bool isNum;
            int num;
            Console.WriteLine("Input your birth year: ");
            var userInput = Console.ReadLine();
            isNum = int.TryParse(userInput, out num);
            var CurrentYear = int.Parse(DateTime.Now.Year.ToString());
            Console.WriteLine($"Your age is: {CurrentYear - num}");
        }
    }
}
