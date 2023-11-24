namespace Exercises.Items
{
    public class EXProj12 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that creates a method that calculates the factorial of a given number. Handle the OverflowException that occurs if the result exceeds the Int32 maximum value.";
        public override void Run()
        {
            try
            {
                Console.Write("Input a number: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (number < 0) throw new ErrorExecption("Number cannot be negative!");

                Console.WriteLine($"Factorial: {FactorialNumber(number)}");

            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Factorial exceeds the maximum value of Int32.");
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

        static int FactorialNumber(int number)
        {
            int factorial = 1;
            for (int i = 1; i < number; i++)
            {
                checked
                {
                    factorial *= i;
                }
                
            }
            return factorial;

        }

        class ErrorExecption : Exception
        {
            public ErrorExecption(string message) : base(message) { }
        }

    }
}
