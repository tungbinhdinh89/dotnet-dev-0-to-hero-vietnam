namespace Exercises.Items
{
    public class OOPProj08 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  - EXERCISE 4-8: DebtEXERCISE 4-8: Debt";
        class Debt
        {
            private double balance;
            private double interestRate;


            public Debt(double initialBalance, double initialInterestRate)
            {
                balance = initialBalance;
                interestRate = initialInterestRate;
            }


            public void PrintBalance()
            {
                Console.WriteLine($"Current balance: {balance}");
            }
            public void WaitOneYear()
            {
                balance *= interestRate; 
            }
        }


        public override void Run()
        {
            Debt mortgage = new Debt(120000.0, 1.01);
            mortgage.PrintBalance();

            mortgage.WaitOneYear();
            mortgage.PrintBalance();

            // Wait 20 years
            int years = 0;
            while (years < 20)
            {
                mortgage.WaitOneYear();
                years = years + 1;
            }

            mortgage.PrintBalance();
        }
    }
}
