namespace Exercises.Items
{
    public class OOPProj07 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  - EXERCISE 4-7: Counter";
        class DecreasingCounter
        {
            private int value;

            public DecreasingCounter(int initialValue)
            {
                value = initialValue;
            }

            public void PrintValue()
            {
                Console.WriteLine($"value: {value}");
            }
            public void Decrement()
            {
                if (value == 0) return;
                value--;
            }
            public void Reset()
            {
                value = 0;
            }
        }


        public override void Run()
        {
            DecreasingCounter counter = new DecreasingCounter(20);
            counter.PrintValue();

            counter.Reset();
            counter.PrintValue();

        }
    }
}
