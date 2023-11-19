namespace Exercises.Items
{
    public class BAProj27 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to count the string \"aa\" in a given string and assume \"aaa\" contains two \"aa\".";
        public override void Run() 
        {
            var str = GetString("Input your string");
            int result = 0; 

            for(int i = 0; i < str.Length -1; i++)
            {
                if (str.Substring(i,2) == "aa")
                {
                    result++;
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
