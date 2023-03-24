using System;
using System.Globalization;
using System.Runtime.CompilerServices;

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

            string num = "1.1";

            Console.WriteLine(Convert.ToDouble(num, numberFormatInfo));

            string num2 = "22";

            Console.WriteLine(200 + int.Parse(num2));

            string num3 = "33,33";

            Console.WriteLine(double.Parse(num3));

            string num4 = "44.44";

            Console.WriteLine(double.Parse(num4, numberFormatInfo));

            string num5 = "5qwerty";

            try
            {
                Console.WriteLine(int.Parse(num5));
                Console.WriteLine("Parse is successful");
            }
            catch (Exception e)
            {
                // Console.WriteLine(e.Message);
                // throw;
                Console.WriteLine($"{num5} ---- it is not possible to parse");
            }

            string mnum6 = "6";

            int x;
            bool result = int.TryParse(mnum6, out x);
            // bool result = int.TryParse(mnum6, out int x);

            if (result)
            {
                Console.WriteLine($"Parse is successful, number = {x}");
            }
            else
            {
                Console.WriteLine($"{x} ---- it is not possible to parse");
            }
        }
    }
}