namespace Exercises.Items
{
    public class Proj43 : BaseProj
    {
        public override string Description => "Write a C# program to check if a given string starts with \"w\" and is immediately followed by two \"ww\".";
        public override void Run()
        {
            var str = GetString("Input your string: ");
            Console.WriteLine($"Check: {CheckString(str)}");
        }

        static string GetString(string msg)
        {
            string str;
            Console.Write(msg);
            str = Console.ReadLine();
            return str;
        }

        static bool CheckString(string str)
        {
            var num = 0;
            for (var i = 0; i < str.Length - 1; i++)
            {
                if (str[0].Equals('w')) num++;
                if (str.Substring(i, 2).Equals("ww") && num > 2)
                    return true;
            }
            return false;
        }
    }
}


