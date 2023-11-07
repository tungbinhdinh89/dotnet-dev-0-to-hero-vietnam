namespace Ex10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            var sum = 0;
            do
            {
                Console.Write("Input Your Number: ");
                isNum = int.TryParse(Console.ReadLine(), out num);

                for (int i = num - 4; i < num + 1; i++)
                {
                    sum += i;
                }
                Console.WriteLine(sum);

            } 
            while (isNum == false);
        }
    }
}
