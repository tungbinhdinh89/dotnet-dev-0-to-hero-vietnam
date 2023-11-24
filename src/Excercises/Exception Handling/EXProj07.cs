namespace Exercises.Items
{
    public class EXProj07 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that reads a list of integers from the user. Handle the exception that occurs if the user enters a value outside the range of Int32.";
        public override void Run()
        {
            try
            {
                List <int> numbers = new List<int>();
                Console.WriteLine("Input a list of intergers. Type 'exit' to finish. ");
                while (true)
                {
                    Console.Write("Input a integer: ");
                    string input1 = Console.ReadLine();
                    if (input1.ToLower() =="exit")  break; 

                    var number = Convert.ToInt32(input1);
                    numbers.Add(number);
                }
               
            foreach (int number in numbers)
                {
                    Console.WriteLine(number);
                }   
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Invalid input. Please enter a valid integer.");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: The value entered is outside the range of Int32.");
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
