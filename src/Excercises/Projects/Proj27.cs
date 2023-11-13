namespace Exercises.Items
{
    public class Proj27 : BaseProj
    {
        public override string Description => "Write a C# program and compute the sum of an integer's digits.";

        public override void Run()
        {

            var number = GetNumber("Input your number");
            Console.WriteLine($"Sum of the digits of the said integer: {SumIntegerDigit(number)}" );


        }


        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out int number))
                {
                    return number;
                }
            }

        }

        static int SumIntegerDigit(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

    }
}
