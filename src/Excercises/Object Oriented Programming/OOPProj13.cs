namespace Exercises.Items
{
    public class OOPProj13 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-13: Statistics";
        class Statistics
        {
            public int count { get; set; }
            public int sum { get; set; }

            public Statistics()
            {
                // initialize the variable count here
                count = 0;
            }

            public void AddNumber(int number)
            {
                // write code here
                sum += number;
                count++;
            }
        }

        public override void Run()
        {
            Statistics statistics = new Statistics();
            statistics.AddNumber(3);
            statistics.AddNumber(5);
            statistics.AddNumber(1);
            statistics.AddNumber(2);
            Console.WriteLine("Count: " + statistics.count);
            Console.WriteLine("Sum: " + statistics.sum);
        }
    }
}
