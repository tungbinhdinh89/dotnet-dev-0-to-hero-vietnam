namespace Exercises.Items
{
    public class OOPProj10 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  EXERCISE 4-10: Gauge";
        class Gauge
        {
            private int value;

            public Gauge()
            {
                value = 0;
            }
            
            public void Decrease()
            {
                if(value == 0) return; value -= 1;
            }

            public void Increase()
            {
                if (value > 5) return; value +=1;
            }

            public bool Full()
            {
                if (value == 5) return true;
                return false;
            }

            public int Value { get { return value; } set {value = value; } }
        }


        public override void Run()
        {
            Gauge g = new Gauge();

            while (!g.Full())
            {
                Console.WriteLine("Not full! Value: " + g.Value);
                g.Increase();
            }

            Console.WriteLine("Full! Value: " + g.Value);
            g.Decrease();
            Console.WriteLine("Not full! Value: " + g.Value);
            Console.WriteLine(g.Full());
        }
    }
}
