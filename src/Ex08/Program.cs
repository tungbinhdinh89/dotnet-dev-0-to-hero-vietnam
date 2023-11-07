namespace Ex08
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

                switch (num)
                {
                    case 2:
                        {
                            Console.WriteLine("Monday");
                            break;
                        }
                    case 3:
                        {
                            Console.WriteLine("Tuesday");
                            break;
                        }
                    case 4:
                        {
                            Console.WriteLine("Wednesday");
                            break;
                        }
                    case 5:
                        {
                            Console.WriteLine("Thurday");
                            break;
                        }
                    case 6:
                        {
                            Console.WriteLine("Friday");
                            break;
                        }
                    case 7:
                        {
                            Console.WriteLine("Saturday");
                            break;
                        }
                    case 8:
                        {
                            Console.WriteLine("Sunday");
                            break;
                        }
                    default:
                        {
                            break;
                        }
                }
            }
            while (num < 2 || num > 8);
        }
    }
}
