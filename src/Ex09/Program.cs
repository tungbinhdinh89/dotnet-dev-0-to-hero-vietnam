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



            }
            while (num < 2 || num > 8);

                
            }
    }
}
