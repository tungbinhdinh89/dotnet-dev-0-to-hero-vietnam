namespace Exercises.Items
{
    public class EXProj11 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that creates a method that takes a string as input and converts it to uppercase. Handle the NullReferenceException that occurs if the input string is null.";
        public override void Run()
        {
            try
            {
                Console.Write("Input a string: ");
                var str = Console.ReadLine();

                if (String.IsNullOrEmpty(str)) throw new ErrorExecption("Input string is null or empty.");

                Console.WriteLine($"Result: {ConvertToUpperCase(str)}");

            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Error: Input string is null.");
            }
            catch (ErrorExecption ex)
            {
                Console.WriteLine("Error: " + ex.Message);
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

        static string ConvertToUpperCase(string str)
        {
           
            return str.ToUpper();

        }

        class ErrorExecption : Exception
        {
            public ErrorExecption(string message) : base(message) { }
        }

    }
}
