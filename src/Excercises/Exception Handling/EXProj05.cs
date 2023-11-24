namespace Exercises.Items
{
    public class EXProj05 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that prompts the user to input a numeric integer and throws an exception if the number is less than 0 or greater than 1000.";
        public override void Run()
        {
            try
            {
                Console.Write("Input an integer: ");
                string input1 = Console.ReadLine();
                int num1 = Convert.ToInt32(input1);

                Range0To1000(num1);
                            }
            catch ( RangeExecption ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Non-numeric value entered.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" An error occurred: " + ex.Message);
            }


        }

     static void Range0To1000 (int number)
        {
            if (number < 0 || number > 1000) throw new RangeExecption("Number out of range. Please enter a number between 0 and 1000.");
            else  Console.WriteLine($"Result: {number}"); 
        }
        class RangeExecption : Exception
        {
            public RangeExecption(string message) : base(message) { }
        }

    }
}
