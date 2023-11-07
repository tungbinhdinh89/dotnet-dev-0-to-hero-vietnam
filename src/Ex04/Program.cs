namespace Ex04
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            Console.WriteLine("Input your character: ");
            var userInput = Console.ReadLine();
            isNum = int.TryParse(userInput, out num);
            if (isNum == false)
            {
                Console.WriteLine("Your input is string");
            }
            else
            {
                Console.WriteLine("Your input is number");
            }    
            
        }
    }
}
