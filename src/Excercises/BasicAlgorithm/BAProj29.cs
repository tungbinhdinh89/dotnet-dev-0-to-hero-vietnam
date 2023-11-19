namespace Exercises.Items
{
    public class BAProj29 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string made of every other character starting with the first in a given string.";
        public override void Run() 
        {
            var str = GetString("Input your string");
            var newStr = "" ;

            for (int i = 0; i < str.Length; i++)
            {
                if(i % 2 == 0)
                {
                    newStr += str.Substring(i, 1);
                }
            }

            Console.WriteLine(newStr);
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
