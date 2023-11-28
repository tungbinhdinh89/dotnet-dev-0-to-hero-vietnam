namespace Exercises.Items
{
    public class OOPProj20 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-20: Television Guide";
        class TelevisionProgram
        {
            private string _name;
            private int _duration;

            public int duration { get { return _duration; } set { duration = value; } }

            public TelevisionProgram(string name, int duration)
            {
                // write code here;
                _name = name;
                _duration = duration;
            }

            public override string ToString()
            {
                // write code here
                return $"{_name}, {_duration} minutes";
            }

        }

        public override void Run()
        {
            List<TelevisionProgram> programList = new();
            Console.WriteLine("Input televison program. Press Enter to exit: ");
            while (true)
            {
                Console.Write("Name: ");
                string name = Console.ReadLine().Trim();

                if (string.IsNullOrEmpty(name))
                {
                    break;
                }
                Console.Write("Duration: ");
                bool successfullyParsed = int.TryParse(Console.ReadLine(), out int number);
                var duration = number;

                TelevisionProgram newProgramList = new TelevisionProgram(name, duration);
                programList.Add(newProgramList);

            }

            Console.WriteLine("Program's maximum duration? ");
            bool successParsed = int.TryParse(Console.ReadLine(), out int num);


            var l = programList.Where(x => x.duration <= num);

            foreach (TelevisionProgram program in l)
            {
                Console.WriteLine(program);
            }
        }
    }
}
