namespace Exercises.Items
{
    public class OOPProj17 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-17: Charging Card";
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
                if (balance < 2.0) return;
                balance -= 2.0;
            }

            public void AddMoney(double amount)
            {
                // write code here
                if (amount < 0)  return; 
                else
                {
                    if (balance + amount > 150)  balance = 150; 
                    else  balance += amount; 

                }

            }
        }

        public override void Run()
        {
            PaymentCard card = new PaymentCard(100);
            Console.WriteLine(card);

            card.AddMoney(49.99);
            Console.WriteLine(card);

            card.AddMoney(10000.0);
            Console.WriteLine(card);

            card.AddMoney(-10);
            Console.WriteLine(card);
        }
    }
}
