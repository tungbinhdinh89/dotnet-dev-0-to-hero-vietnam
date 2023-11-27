namespace Exercises.Items
{
    public class OOPProj12 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-12: Multiplier";
        class Multiplier
        {
            private int _number;
            private int _value;

            public Multiplier(int number)
            {
                _number = number;
                _value = number; // Initialize the current value with the initial number
            }

            public int Multiply(int number)
            {
                _value *= number; // Multiply the current value by the provided number
                return _value;   // Return the updated value
            }
        }

        public override void Run()
        {
            Multiplier multiplyByThree = new Multiplier(3);
            Console.WriteLine("multiplyByThree.Multiply(2): " + multiplyByThree.Multiply(2));

            Multiplier multiplyByFour = new Multiplier(4);
            Console.WriteLine("multiplyByFour.Multiply(2): " + multiplyByFour.Multiply(2));
            Console.WriteLine("multiplyByThree.Multiply(1): " + multiplyByThree.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(1): " + multiplyByFour.Multiply(1));
            Console.WriteLine("multiplyByFour.Multiply(3): " + multiplyByFour.Multiply(3));
        }
    }
}
