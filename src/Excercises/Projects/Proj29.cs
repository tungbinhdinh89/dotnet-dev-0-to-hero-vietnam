namespace Exercises.Items
{
    public class Proj29 : BaseProj
    {
        public override string Description => "Write a C# program to find the size of a specified file in bytes.";

        public override void Run()
        {
            string path =  GetString("Input your path of file: ");

            var file = new DirectoryInfo(path);
            FileInfo[] fileArr = file.GetFiles();
            foreach ( FileInfo fileItem in fileArr )
            {
                Console.WriteLine($"Name of file: {fileItem.Name}, Size of a file: {fileItem.Length} bytes");
            }
        
        }

        static string GetString(string msg)
        {
            string str;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                if (!Path.Exists(str))
                {
                    Console.WriteLine("Invalid Path");
                }
                
            }
            while (!Path.Exists(str));
            return str;
        }
    }
}
