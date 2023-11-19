namespace Exercises.Items
{
    public class BAProj30 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to create a string like \"aababcabcd\" from a given string \"abcd\".";
        public override void Run()
        {
            var str = GetString("Input your string");
            var newStr = "";
            for (int i = 0; i < str.Length; i++)
            {
                //newStr += str.Remove(i,str.Length -i);
                newStr += str.Substring(0, i + 1);
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
