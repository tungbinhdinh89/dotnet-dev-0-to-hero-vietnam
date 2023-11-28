namespace Exercises.Items
{
    public class OOPProj25 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/EXERCISE 4-25: File Names";
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
            Console.WriteLine("Which file should have its contents printed? ");
            var str = Console.ReadLine();
            var path = "C:\\Users\\tungb\\source\\repos\\dotnet-dev-0-to-hero-vietnam\\src\\Excercises\\Object Oriented Programming\\" + str;

            if (Path.Exists(path))
            {
                string[] lines = File.ReadAllLines(path);
                foreach (string line in lines)
                {
                    Console.WriteLine($"{line}");
                }
            }
            else { Console.WriteLine("File not found!"); }
        }
    }
}
