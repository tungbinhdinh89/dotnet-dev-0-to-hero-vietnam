namespace Exercises.Items
{
    public class BAProj25 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string which is n (non-negative integer) copies of a given string.";
        public override void Run() 
        {
            var str = GetString("Input your string");
            var num = GetNumber("Input your number");
            var result = string.Empty; 
            for(int i = 0; i < num; i++)
            {
                result += str;
            }

            Console.WriteLine(result);
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
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out int val)) return val;
            }
        }
    }
}
