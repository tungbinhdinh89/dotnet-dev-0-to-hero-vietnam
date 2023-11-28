namespace Exercises.Items
{
    public class OOPProj22 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/ EXERCISE 4-22: Reading Strings";
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
            int stringCount = 0;
            List<PrintString> strings = new();
            Console.WriteLine($"Input your string. Type \"end\" to exit: ");
            while (true)
            {
                Console.Write("Input string: ");
                string stringName = Console.ReadLine().Trim();

                if (stringName.ToLower() == "end")
                {
                    break;
                }
                stringCount++;
                PrintString newStr = new(stringName);
                strings.Add(newStr);

            }
            foreach (PrintString str in strings)
            {
                Console.WriteLine(str.ToString());
            }
            Console.WriteLine(stringCount);

        }
    }
}
