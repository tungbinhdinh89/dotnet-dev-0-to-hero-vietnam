namespace Exercises.Items
{
    public class BAProj39 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if a triple is present in an array of integers or not. If a value appears three times in a row in an array it is called a triple.";
        public override void Run()
        {


            bool IsTripleInArr(int[] num)
            {
                for (int i = 0; i < num.Length - 1; i++)
                {
                    if (num[i] == num[i +1] && num[i +1] == num[i + 2]) return true;
                }
                return false;
            }
            Console.WriteLine(IsTripleInArr(new[] { 1, 1, 2, 2, 1 }));
            Console.WriteLine(IsTripleInArr(new[] { 1, 1, 2, 1, 2, 3 }));
            Console.WriteLine(IsTripleInArr(new[] { 1, 1, 1, 2, 2, 2, 1 }));
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
                var c = Console.ReadLine();
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
