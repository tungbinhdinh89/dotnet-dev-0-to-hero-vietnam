namespace Ex09
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num;
            bool isNum;
            do
            {
                Console.Write("Input Your Number: ");
                isNum = int.TryParse(Console.ReadLine(), out num);

                //var day = switch num;
                //{
                //    2 => "Monday",
                //   3 => "Tuesday",

                //}
                var day = num switch { 
                    2 => "Monday", 
                    3=> "Tuesday" ,
                    4 => "Wednesday",
                    5 => "Thurday",
                    6 => "Friday",
                    7 => "Saturday",
                    8 => "Monday"
                };



            }
            while (num < 2 || num > 8);

                
            }
    }
}
