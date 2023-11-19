namespace Exercises.Items
{
    public class BAProj26 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string that is n (non-negative integer) copies of the first 3 characters of a given string. If the given string is shorter than 3, return n copies of the string.";
        public override void Run() 
        {
            var str = GetString("Input your string");
            var num = GetNumber("Input your number");
            var result = string.Empty; 
            var newStr = str.Length > 3? str.Substring(0, 3) : str;

            for(int i = 0; i < num; i++)
            {
                result += newStr;
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
