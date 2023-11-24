namespace Exercises.Items
{
    public class EXProj08 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that implements a method that divides two numbers. Handle the DivideByZeroException that occurs if the denominator is 0.";
        public override void Run()
        {
            try
            {
                Console.Write("Input your first number: ");
                var number1 = Convert.ToInt32(Console.ReadLine());
                Console.Write("Input your second number: ");
                var number2 = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine($"Result: {number1 / number2}");

            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: Division by zero is not allowed.");
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
