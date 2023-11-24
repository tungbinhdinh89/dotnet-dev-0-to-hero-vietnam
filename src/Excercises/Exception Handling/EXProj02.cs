namespace Exercises.Items
{
    public class EXProj02 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program to implement a method that takes an integer as input and throws an exception if the number is negative. Handle the exception in the calling code.";
        public override void Run()
        {
            //try
            //{
            //    Console.Write("Input an integer: ");
            //    string input1 = Console.ReadLine();
            //    int num1 = Convert.ToInt32(input1);

            //    if (num1 >= 0)
            //    {
            //                           Console.WriteLine($"Valid input: {num1}");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Error: Negative number not allowed.");
            //    }

            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Invalid input. Please enter an integer.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine(" An error occurred: " + ex.Message);
            //}
            try
            {
                Console.Write("Input an integer: ");
                string input1 = Console.ReadLine();
                int num1 = Convert.ToInt32(input1);

                ValidatePositiveNumber(num1);
                Console.WriteLine($"Valid input: {num1}");
            }
            catch (NegativeNumberExecption ex)
            {
                Console.WriteLine($"Error : {ex.Message}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter an integer.");
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }


        }

        static void ValidatePositiveNumber(int number)
        {
            if (number < 0)
            {
                throw new NegativeNumberExecption("Negative number not allowed");
            }
        }

        class NegativeNumberExecption : Exception
        {
            public NegativeNumberExecption(string message) : base(message) { }
        }

    }
}
