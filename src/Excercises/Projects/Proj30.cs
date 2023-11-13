using static System.Net.Mime.MediaTypeNames;

namespace Exercises.Items
{
    public class Proj30 : BaseProj
    {
        public override string Description => "Write a C# program to convert a hexadecimal number to a decimal number.";

        public override void Run()
        {
            string hexaNumber = GetString("Input your hexadecimal number: ");
            int decimalNumber = int.Parse(hexaNumber, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine($"Hexadecimal number: {hexaNumber} convert to Decimal number: {decimalNumber}");
        }

        static string GetString(string msg)
        {
            string str;
            do
            {
                Console.WriteLine(msg);
                str = Console.ReadLine();
                if (!IsHexaDecimalNumber(str))
                {
                    Console.WriteLine("String is not Hexadecimal Number");
                }
                
            }
            while (!IsHexaDecimalNumber(str));
            return str;
        }

        static bool IsHexaDecimalNumber(string str)
        {
            //bool isHex;
            //foreach ( char c in str )
            //{
            //    isHex = ((c >= '0' && c <= '9') ||
            //     (c >= 'a' && c <= 'f') ||
            //     (c >= 'A' && c <= 'F'));

            //    if(!isHex) return false;
            //}
            //return true;
            return System.Text.RegularExpressions.Regex.IsMatch(str, @"\A\b[0-9a-fA-F]+\b\Z");
        }
    }
}
