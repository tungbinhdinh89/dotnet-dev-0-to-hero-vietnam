namespace Exercises.Items
{
    public class OOPProj05 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  - EXERCISE 4-5: Whistle";
        class Whistle
        {
            private string _sound;

            public Whistle(string whistleSound)
            {
                _sound = whistleSound;
            }

            public void Sound()
            {
                Console.WriteLine(_sound);
            }
        }


        public override void Run()
        {

            Whistle duckWhistle = new Whistle("Kvaak");
            Whistle roosterWhistle = new Whistle("Peef");

            duckWhistle.Sound();
            roosterWhistle.Sound();
            duckWhistle.Sound();

        }
    }
}
