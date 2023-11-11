namespace Exercises.Items
{
    public class Proj26 : BaseProj
    {
        public override string Description => "Write a C# program to compute the sum of the first 500 prime numbers.";

        public override void Run()
        {
            int sum = 0;
            int prime = 0;
            int n = 2;
            while (true)
            {

            }


        }


        static bool IsPrime(int n)
        {
            int x = (int)(Math.Floor(Math.Sqrt(n)));
            if (n == 1) return false;
            if (n == 2) return true;

            for (int i = 2; i < x; i++)
            {
                if (n % i == 0) return false;
            }
            return true;
        }

    }
}
