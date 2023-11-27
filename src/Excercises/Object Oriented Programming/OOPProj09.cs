namespace Exercises.Items
{
    public class OOPProj09 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  -EXERCISE 4-9: Dalmatian";
        class Dalmatian
        {
            private string _name;
            private int _spots;

            public Dalmatian(string name, int spots)
            {
                _name = name;
                _spots = spots;

            }

            public string Name { get { return _name; } set { _name = value; } }
            public int Spots { get { return _spots; } set { _spots = value; } }

        }


        public override void Run()
        {
            Dalmatian spotty = new Dalmatian("Spot", 306);
            Console.WriteLine(spotty.Name + " is a very good dog. He has " + spotty.Spots + " darker spots in his fur.");
        }
    }
}
