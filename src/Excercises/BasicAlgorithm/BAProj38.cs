namespace Exercises.Items
{
    public class BAProj38 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to count the number of two 5's next to each other in an array of integers. Count the situation where the second 5 is actually a 6.";
        public override void Run()
        {
            
              
            int CountNumber(int[] num)
            {
                var count = 0;

                for (int i = 0; i < num.Length -1 ; i++)
                {
                    if (num[i] ==5 && (num[i+1]== 5 || num[i + 1] == 6)) count++;
                }
                return count;  
            }

            Console.WriteLine(CountNumber( new[]{ 5, 5, 2 } ));
            Console.WriteLine(CountNumber(new[] { 5, 5, 2, 5, 5 }));
            Console.WriteLine(CountNumber(new[] { 5, 6, 2, 9 }));

        }

        static string GetString(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                return str;
            }
        }

        static char GetChar(string msg)
        {

            while (true)
            {
                Console.WriteLine(msg);
                 var c  = Console.ReadLine();
                if (c.Length < 2) return c[0];
            }
        }

        static int GetNumber(string msg)
        {
            int num;
            do
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out num)) ;

            }
            while (true && num < 0);
            return num;
        }
    }
}
