namespace Exercises.Items
{
    public class OOPProj01 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  - EXERCISE 4-1: First Account";
        class Account
        {
            private string _accountName;
            //private double _balance;
            public double _balance { get; set; }

            public Account(string accountName, double balance)
            {
                _accountName = accountName;
                _balance = balance;
            }

            public void Withdrawal(int number)
            {
                _balance = _balance - number;
            }

            public double Deposit(int number)
            {
                _balance = _balance + number;
                return _balance;
            }

            public override string ToString()
            {
                return $"Accout {_accountName} balance {_balance}";
            }

        }

        public override void Run()
        {
            Account heikkisAccount = new Account("Heikki's account", 100.00);

            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);

            heikkisAccount.Deposit(20);

            Console.WriteLine("The balance of Heikki's account is now: " + heikkisAccount._balance);

            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);


        }


    }
}
