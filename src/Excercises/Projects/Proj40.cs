namespace Exercises.Items
{
    public class Proj40 : BaseProj
    {
        public override string Description => "Write a C# program that checks the nearest value of 20 of two given integers and return 0 if two numbers are same.";
        public override void Run()
        {
            var n1 = GetNumber("Input your first number: ");
            var n2 = GetNumber("Input your second number: ");

            Console.WriteLine($"The number is nearest of 20 : {NearestOf20(n1,n2)}");
            
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

        static int NearestOf20(int n1, int n2)
        {
            int n = 20;
            int value;
            return value = (Math.Abs(n1 - n) == Math.Abs(n2 - n))?0:(Math.Abs(n1 - n) < Math.Abs(n2 - n) ? n1 : n2);
        }
    }
}

