namespace Exercises.Items
{
    public class OOPProj24 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/ EXERCISE 4-24: Reading File";
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
            var filePath = "data.txt";
            if (Path.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                foreach (string line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else Console.WriteLine("File not found");
        }
    }
}
