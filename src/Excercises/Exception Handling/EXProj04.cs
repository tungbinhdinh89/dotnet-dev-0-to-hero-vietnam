using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;

namespace Exercises.Items
{
    public class EXProj04 : ExceptionHandlingProj
    {
        public override string Description =>" Write a C# program that implements a method that takes an array of integers as input and calculates the average value. Handle the exception if the array is empty.";
        public override void Run()
        {
            try
            {
                Console.WriteLine("Input size of the array");
                var count = Convert.ToInt32(Console.ReadLine());

                int[] numbers = new int[count];

                for (int i = 0; i < count; i++)
                {
                    Console.Write($"Input element {i} in arr: ");
                    var input = Convert.ToInt32(Console.ReadLine());
                    numbers[i] = input;
                }

                Console.WriteLine($"Result: {CalculateAverage(numbers)}");
            }
            catch (EmptyArrayExection ex)
            { Console.WriteLine($"Error: {ex.Message}"); }
            catch (FormatException) {
                Console.WriteLine("Error: Invalid input. Please input integers only.");
            }
            catch (Exception ex) 
            {
                Console.WriteLine($"An error occurred: {ex.Message}");
                    }
        }

     static double CalculateAverage (int[] numbers)
        {
            //double result ;
            if (numbers.Length == 0) throw new EmptyArrayExection("Array is empty. Cannot calculate average.");
            else
            {
                int sum = 0;
                for (int i = 0; i < numbers.Length; i++)
                {
                    
                     sum += numbers[i];
                }
                return  (double)sum / numbers.Length;
            }
        }
        class EmptyArrayExection : Exception
        {
            public EmptyArrayExection(string message) : base(message) { }
        }

    }
}
