namespace Exercises.Items
{
    public class Proj36 : BaseProj
    {
        public override string Description => "Write a C# program to check if an integer (from the two given integers) is in the range -10 to 10.";
        public override void Run()
        {
            var n1 = GetNumber("Input your first number: ");
            var n2 = GetNumber("Input your second number: ");

            Console.WriteLine(IsNumberInRange(n1, n2));

        }

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.Write(msg);
                if (int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }
            }

        }

        static bool IsNumberInRange(int n1, int n2)
        {
            return ((n1 >= -10 && n1 <= 10) || (n2 < -10 && n2 > 10)) ? true : false;
        }
    }
}

