namespace Exercises.Items
{
    public class BAProj36 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string from a given string where a specified character is removed except for the beginning and ending positions.";
        public override void Run()
        {
            var str = GetString("Input your first string");
            var c = GetChar("Input your character");
            
            string GetNewString (string str,char c)
            {
                var newStr = String.Empty;

                for (int i = 1; i < str.Length - 2; i++)
                {
                    if (str[i] == c) {
                        str =str.Remove(i,1);
                    }
                }
                return str;  
            }



            Console.WriteLine(GetNewString(str, c));
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
