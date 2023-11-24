using System.Net;

namespace Exercises.Items
{
    public class EXProj13 : ExceptionHandlingProj
    {
        public override string Description => "Write a C# program that reads a list of URLs from the user and downloads the content of each URL. Handle the exception if any URL is inaccessible.";
        public override void Run()
        {
            Console.WriteLine("Input the URLs (one URL per line, press Enter to complete):");
            try
            {
              while (true)
                {
                    var url = Console.ReadLine();
                    if(String.IsNullOrEmpty(url))
                    {
                        throw new Exception("URL is not empty");
                        break;
                    }
                    CheckURL(url);
                }
               
            }
            catch (OverflowException)
            {
                Console.WriteLine("Error: Factorial exceeds the maximum value of Int32.");
            }
            catch (WebException ex)
            {
                Console.WriteLine($"Error accessing URL: {ex.Message}");
            }
            catch (Exception ex)
            {
                Console.WriteLine(" An error occurred: " + ex.Message);
            }
        }

        static void CheckURL(string url)
        {
            WebClient webClient = new();
            string content = webClient.DownloadString(url); 

            Console.WriteLine($"Content of URL '{url}' : ");
            Console.WriteLine(content);
            Console.WriteLine();

        }

        class ErrorExecption : Exception
        {
            public ErrorExecption(string message) : base(message) { }
        }

    }
}
