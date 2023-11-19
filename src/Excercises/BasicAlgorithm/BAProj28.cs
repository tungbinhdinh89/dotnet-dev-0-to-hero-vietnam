namespace Exercises.Items
{
    public class BAProj28 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if the first appearance of \"a\" in a given string is immediately followed by another \"a\".";
        public override void Run() 
        {
            var str = GetString("Input your string");
            int count = 0;
            var result = false ; 

            for(int i = 0; i < str.Length -1; i++)
            {
                if (str[i] == 'a') count++;
                if (str.Substring(i, 2) == "aa" && count < 2)
                {
                    result = true;
                }
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
