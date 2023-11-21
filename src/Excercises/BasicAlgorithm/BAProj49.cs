namespace Exercises.Items
{
    public class BAProj49 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if three given numbers are in strict increasing order.\r\nFor example, 4 7 15, or 45, 56, 67, but not 4 ,5, 8 or 6, 6, 8. However, if a fourth parameter is true, equality is allowed, such as 6, 6, 8 or 7, 7, 7.";
        public override void Run()
        {
            
          bool CheckNumber(int n1, int n2, int n3, bool b) {
                return b ? n1 <= n2 && n2 <= n3 : n1 < n2 && n2 < n3;
            }
            Console.WriteLine(CheckNumber(1, 2, 3, false));
            Console.WriteLine(CheckNumber(1, 2, 3, true));
            Console.WriteLine(CheckNumber(10, 2, 30, false));
            Console.WriteLine(CheckNumber(10, 10, 30, true));

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

        
        static int GetNumber(string msg)
        {
            int num;
            do
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out num)) ;
                return num;

            }
            while (true);
            
        }
    }
}
