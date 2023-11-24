namespace Exercises.Items
{
    public class EXProj10 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that reads a number from the user and calculates its square root. Handle the exception if the number is negative.";
        public override void Run()
        {
            try
            {
                Console.Write("Input a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0) throw new ErrorExecption("Number cannot be negative!");

                Console.WriteLine($"Square root: {SquareNumber(number)}");

            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please input a valid number.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" An error occurred: " + ex.Message);
            }
        }

        static double SquareNumber(int number)
        {
           
            return Math.Sqrt(number);

        }

        class ErrorExecption : Exception
        {
            public ErrorExecption(string message) : base(message) { }
        }

    }
}
