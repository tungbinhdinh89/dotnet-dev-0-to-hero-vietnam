namespace Exercises.Items
{
    public class EXProj09 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that creates a method that reads a date from the user in the format \"dd/mm/yyyy\" and converts it to a DateTime object. Handle an exception if the input format is invalid.";
        public override void Run()
        {
            try
            {
                Console.Write("Input a date. Format => dd/mm/yyyy: ");
                DateTime date = ConvertToDate(Console.ReadLine());

                Console.WriteLine($"Date: {date.ToShortDateString()}");

            }
                   catch (FormatException)
            {
                Console.WriteLine("Error: Invalid date format. Please input a valid date in the format dd/mm/yyyy.");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" An error occurred: " + ex.Message);
            }
        }

        static DateTime ConvertToDate(string date)
        {
            string[] format = { "dd/MM/yyyy" };
            return DateTime.ParseExact(date, format, null, System.Globalization.DateTimeStyles.None);
        }

        class RangeExecption : Exception
        {
            public RangeExecption(string message) : base(message) { }
        }

    }
}
