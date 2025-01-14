﻿namespace Exercises.Items
{
    public class OOPProj15 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-15: Using Card";
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
                balance -= 10.60;   
            }

            public void DrinkCoffee()
            {
                balance -= 2.0;
            }
        }

        public override void Run()
        {
            PaymentCard card = new PaymentCard(50);
            Console.WriteLine(card);

            card.EatLunch();
            Console.WriteLine(card);

            card.DrinkCoffee();
            Console.WriteLine(card);
        }
    }
}
