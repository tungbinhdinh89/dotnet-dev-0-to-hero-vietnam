namespace Exercises.Items
{
    public class EXProj03 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that reads a file path from the user and tries to open the file. Handle exceptions if the file does not exist.";
        public override void Run()
        {

            //try
            //{
            //    Console.Write("Input your path: ");
            //    string input1 = Console.ReadLine();

            //    CheckPath(input1);
            //    Console.WriteLine($"Valid input: {input1}");
            //}
            //catch (PathExecption ex)
            //{
            //    Console.WriteLine($"Error : {ex.Message}");
            //}
            //catch (FormatException)
            //{
            //    Console.WriteLine("Error: Invalid input. Please enter a path.");
            //}
            //catch (Exception ex)
            //{
            //    Console.WriteLine("An error occurred: " + ex.Message);
            //}

            Console.Write("Input your path: ");
            string input1 = Console.ReadLine();
            try
            {
                using (StreamReader reader = new StreamReader(input1))
                {
                    Console.WriteLine("File opened successfully.");
                }
            }
            catch (FileNotFoundException)
            {
                Console.WriteLine("Error: File not found.");
            }
            catch (IOException ex)
            {
                Console.WriteLine("An error occurred while accessing the file: " + ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An unexpected error occurred: " + ex.Message);
            }

        }

        static void CheckPath(string path)
        {
           
            if (String.IsNullOrEmpty(path))
            {
                throw new PathExecption("Path not empty or null");
            }
            if (!Path.Exists(path))
            {
                throw new PathExecption("Path not exist");
            }
        }

        class PathExecption : Exception
        {
            public PathExecption(string message) : base(message) { }
        }

    }
}
