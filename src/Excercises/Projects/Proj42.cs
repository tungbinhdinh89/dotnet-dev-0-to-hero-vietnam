namespace Exercises.Items
{
    public class Proj42 : BaseProj
    {
        public override string Description => "Write a C# program to create a string where the first 4 characters are in lower case. If the string is less than 4 letters, make the whole string in upper case.";
        public override void Run()
        {
            var str = GetString("Input your string: ");
            Console.WriteLine($"The new string is: {NewString(str)}");
        }

        static string GetString(string msg)
        {
            string str;
                Console.Write(msg);
                str = Console.ReadLine();
            return str;
        }

        static string NewString(string str)
        {
            string newStr;
            return newStr = str.Length < 4 ? str.ToUpper() : str.Substring(0, 4).ToLower() + str.Substring(4);
        }
    }
}


