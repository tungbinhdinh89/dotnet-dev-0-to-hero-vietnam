namespace Exercises.Items
{
    public class BAProj48 : BaseAlgorithmProj
    {
        public override string Description => "Write a C# Sharp program to check if y is greater than x, and z is greater than y from three given integers x,y,z.";
        public override void Run()
        {
            var num1 = GetNumber("Input your first number");
            var num2 = GetNumber("Input your second number");
            var num3 = GetNumber("Input your third number");

            var result = (num1 < num2 && num2 < num3)?true:false;
          


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
                return num;

            }
            while (true);
            
        }
    }
}
