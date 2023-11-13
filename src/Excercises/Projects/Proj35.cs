namespace Exercises.Items
{
    public class Proj35 : BaseProj
    {
        public override string Description => "Write a C# program to check two given numbers where one is less than 100 and the other is greater than 200.";

        public override void Run()
        {
            var n1 = GetNumber("Input your first number: ");
            var n2 = GetNumber("Input your second number: ");
            
           Console.WriteLine(IsLessThan100AndGreaterThan200(n1, n2));

        }

        static int GetNumber(string msg)
        {
            while (true) {
                Console.Write(msg);
                if(int.TryParse(Console.ReadLine(), out var num))
                {
                    return num;
                }
            }
            
        }

        static bool IsLessThan100AndGreaterThan200(int n1, int n2)
        {
            return ((n1 < 100 && n2 > 200) || (n2<100 && n1 > 200))?true:false;
        }
    }
}

