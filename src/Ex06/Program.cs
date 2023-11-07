namespace Ex06
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            do
            {
            Console.Write("Input your number: ");
                isNum = int.TryParse(Console.ReadLine(), out num);
            } while (isNum == false);
        }
    }
}
