namespace Ex07
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            do
            {
                Console.Write("Input Your Number: ");
                isNum = int.TryParse(Console.ReadLine(), out num);

                if (num ==2)
                {
                    Console.WriteLine("Monday");
                }
                else if (num == 3)
                {
                    Console.WriteLine("Tuesday");
                }
                else if (num == 4)
                {
                    Console.WriteLine("Wednesday");
                }
                else if (num == 5)
                {
                    Console.WriteLine("Thurday");
                }
                else if (num == 6)
                {
                    Console.WriteLine("Friday");
                }
                else if (num == 7)
                {
                    Console.WriteLine("Saturday");
                }
                else if (num == 8)
                {
                    Console.WriteLine("Sunday");
                }
            }
            while (num < 2 || num > 8);




        }
    }
}
