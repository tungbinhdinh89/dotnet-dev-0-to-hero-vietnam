namespace Exercises.Items
{
    public class DTProj03 : DataTypesProj
    {
        public override string Description => "Write a C# Sharp program that takes userid and password as input (string type). After 3 unsuccessful attempts, the user will be rejected.";
        public override void Run()
        {
            Console.Write("N.B. : Defaule username and password is : username and password\n");
            //Console.Write("---------------------------------\n");
            //string username = "username";
            //string password = "password";

            int count = 0;

            do
            {
                string username = GetString("Input your username: ");
                string password = GetString("Input your password: ");

                if (username == "username" && password == "password")
                {
                    Console.WriteLine("Password entered successfull!");
                    break;
                }

                count++;
                if (count == 3) Console.WriteLine("Login attemp more than three times.Try later!");
                else { Console.WriteLine("Try again!"); }
               

            } while (count < 3);

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

        static char GetChar(string msg)
        {

            while (true)
            {
                Console.WriteLine(msg);
                var c = Console.ReadLine();
                if (c.Length < 2) return c[0];
            }
        }

    }
}
