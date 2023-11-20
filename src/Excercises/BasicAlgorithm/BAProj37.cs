namespace Exercises.Items
{
    public class BAProj37 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string of characters at indexes 0,1, 4,5, 8,9 ... from a given string.\r\n\r\nSample Input:";
        public override void Run()
        {
            var str = GetString("Input your first string");
              
            string GetNewString (string str)
            {
                var newStr = String.Empty;

                for (int i = 0; i < str.Length ; i++)
                {
                    if (i == 0 || i == 1 || i == 4 || i == 5 || i == 8 || i == 9) newStr += str[i];
                }
                return newStr;  
            }



            Console.WriteLine(GetNewString(str));
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
