using System;
using System.Globalization;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // string data = Console.ReadLine();
            //
            // int res = 100 + Convert.ToInt32(data);
            //
            // Console.WriteLine(res);

            // Console.WriteLine($"you have typed {data}");
            // Console.WriteLine("you have typed " + data);

            NumberFormatInfo numberFormatInfo = new NumberFormatInfo()
            {
                NumberDecimalSeparator = "."
            };

            string num = "1.9";

            Console.WriteLine(Convert.ToDouble(num, numberFormatInfo));
        }
    }
}