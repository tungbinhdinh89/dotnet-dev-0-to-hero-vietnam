namespace Exercises.Items
{
    public class EXProj06 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that reads a string from the user and converts it to an integer. Handle the exception if the input cannot be parsed into an integer.";
        public override void Run()
        {
            try
            {
                Console.Write("Input a integer: ");
                string input1 = Console.ReadLine();
                var number = Convert.ToInt32(input1);
                Console.WriteLine($"Number: {number}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" An error occurred: " + ex.Message);
            }
        }

        class RangeExecption : Exception
        {
            public RangeExecption(string message) : base(message) { }
        }

    }
}
