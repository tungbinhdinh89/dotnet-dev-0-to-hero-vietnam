namespace Exercises.Items
{
    public class OOPProj02 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  - EXERCISE 4-2: First Transfer";
        class Account
        {
            private string _accountName;
            private double _balance;

            public Account(string accountName, double balance)
            {
                _accountName = accountName;
                _balance = balance;
            }

            public double Withdrawal(int number)
            {
                _balance = _balance - number;
                return _balance;
            }

            public double Deposit(int number)
            {
                _balance = _balance + number;
                return _balance;
            }

            public override string ToString()
            {
                return $"Account {_accountName} balance {_balance}";
            }

        }

        public override void Run()
        {
            Account heikkisAccount = new Account("Heikki's account", 1000.0);
            Account personalAccount = new Account("Personal account", 0);

            Console.WriteLine("Intial state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);


            // excute state
            heikkisAccount.Withdrawal(100);
            personalAccount.Deposit(100);

            Console.WriteLine("End state");
            Console.WriteLine(heikkisAccount);
            Console.WriteLine(personalAccount);


        }


    }
}
