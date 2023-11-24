namespace Exercises.Items
{
    public class EXProj01 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that prompts the user to input two numbers and divides them. Handle an exception when the user enters non-numeric values.";
        public override void Run()
        {
            //var num1 = GetNumber("Input your first number: ");
            //var num2 = GetNumber("Input your second number: ");
            try
            {
                Console.Write("Input first number: ");
                string input1 = Console.ReadLine();
                double num1 = Convert.ToDouble(input1);
                Console.Write("Input second number: ");
                string input2 = Console.ReadLine();
                double num2 = Convert.ToDouble(input2);

                if (num2 != 0)
                {
                    var result = num1 / num2;
                    Console.WriteLine($"Result: {result}");
                }
                else
                {
                    Console.WriteLine("Error: Cannot divine by zero");
                }

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

        static int GetNumber(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                if (int.TryParse(Console.ReadLine(), out var number))
                {
                    return number;
                }
            }
        }

        static string GetString(string msg)
        {
            while (true)
            {
                Console.WriteLine(msg);
                string str = Console.ReadLine();
                return str;
            }
        }

    }
}
