namespace Exercises.Items
{
    public class OOPProj19 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-19: Personal Infromation Main";
        class PersonalInformation
        {
            private string _firstName;
            private string _lastName;
            private string _id;

            public PersonalInformation(string firstName, string lastName, string id)
            {
                // write code here;
                _firstName = firstName;
                _lastName = lastName;
                _id = id;

            }

            public override string ToString()
            {
                // write code here
                return $"{_firstName} {_lastName}";
            }

        }

        public override void Run()
        {
            List<PersonalInformation> person = new();
            Console.WriteLine("Input personal information. Press Enter to exit: ");
            while (true)
            {
                Console.Write("First name: ");
                string firstName = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(firstName))
                {
                    break;
                }
                Console.Write("Last name: ");
                string lastName = Console.ReadLine().Trim();

                Console.Write("Identification number:: ");
                string id = Console.ReadLine().Trim();

                PersonalInformation newPerson = new PersonalInformation(firstName, lastName, id);
                person.Add(newPerson);

            }
            Console.WriteLine("");
            foreach (PersonalInformation p in person)
            {
                Console.WriteLine(p);
            }
        }
    }
}
