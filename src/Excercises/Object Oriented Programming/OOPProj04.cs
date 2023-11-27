namespace Exercises.Items
{
    public class OOPProj04 : ObjectOrientedProgrammingProj
    {
        public override string Description => "https://raisanenmarkus.github.io/csharp/part4/4/  -EXERCISE 4-04: Classroom";
        class Account
        {
            class Room
            {
                private string _code;
                private int _seats;

                public Room (string classCode,int numberOfSeats)
                {
                    _code = classCode;
                    _seats = numberOfSeats;
                }
            }
        }

        public override void Run()
        {



        }


    }
}
