namespace Exercises.Items
{
    public class OOPProj14 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-14: Payment Card";
        class PaymentCard
        {
            private double balance;

            public PaymentCard(double openingBalance)
            {
                // write code here
                balance = openingBalance;
            }

            public override string ToString()
            {
                // write code here
                return $"The card has a balance of {balance} euros";
            }
        }

        public override void Run()
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);
        }
    }
}
