namespace Exercises.Items
{
    public class OOPProj23 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/ EXERCISE 4-23: Reading Integers";
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
            Console.WriteLine($"Input your string. Type \"end\" to exit: ");
            while (true)
            {
                Console.Write("string:");
                var str = Console.ReadLine().ToLower();
                if (str == "end")
                {
                    break;
                }

                var isParsed = int.TryParse(str, out int num);
                var result = num * num * num;
                Console.WriteLine(result);
            }


        }
    }
}
