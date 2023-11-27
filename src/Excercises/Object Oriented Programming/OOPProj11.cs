namespace Exercises.Items
{
    public class OOPProj11 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-11: Agent";
        class Agent
        {
            private string _firstName;
            private string _lastName;

            public Agent(string firstName, string lastName)
            {
                _firstName = firstName;
                _lastName = lastName;
            }

            public override string ToString()
            {
                return $"My name is {_lastName}. {_firstName} {_lastName}";
            }

        }


        public override void Run()
        {
            Agent bond = new Agent("James", "Bond");
            Console.WriteLine(bond);

            Agent bourne = new Agent("Jason", "Bourne");
            Console.WriteLine(bourne);
        }
    }
}
