namespace Exercises.Items
{
    public class OOPProj26 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/EXERCISEEXERCISE 4-26: Guestlist Txt";
        class PrintString
        {

            private string _stringName;

            public PrintString(string stringName)
            {
                _stringName = stringName;
            }

            public override string ToString()
            {
                // write code here
                return $"{_stringName}";
            }

        }

        public override void Run()
        {
            var path = "C:\\Users\\tungb\\source\\repos\\dotnet-dev-0-to-hero-vietnam\\src\\Excercises\\Object Oriented Programming\\names.txt";

            if (!File.Exists(path))
            {
                Console.WriteLine("Can not found file");
                return;
            }

            string[] guestList = File.ReadAllLines(path);
            Console.WriteLine("Enter names, an empty line quits. ");

            while (true)
            {
                var str = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(str)) break;
            
                var found = false;

                foreach (string guest in guestList)
                {
                    Console.WriteLine(guest);

                    if (guest == str)
                    {
                        found = true;
                        Console.WriteLine("The name is on the list. ");
                        break;
                    }
                }

                if (!found) Console.WriteLine("The name is not on the list. ");
            }
            Console.WriteLine("Thank you!");
        }
    }
}
