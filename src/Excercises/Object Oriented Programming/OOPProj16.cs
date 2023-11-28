namespace Exercises.Items
{
    public class OOPProj16 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-16: Checking Balance";
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

            public void EatLunch()
            {
                if (balance < 10.60) return;
                balance -= 10.60;   
            }

            public void DrinkCoffee()
            {
                if (balance <2.0) return;
                balance -= 2.0;
            }
        }

        public override void Run()
        {
            PaymentCard card = new PaymentCard(10);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}
