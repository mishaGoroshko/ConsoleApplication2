using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int a = 5;
            // int b = 2;

            // double a = 5;
            // int b = 2;

            // double res = a / b;

            // int a = 5;
            // int b = 2;
            //
            // double res = (double)(a + b) / 2;
            //
            // Console.WriteLine(res);
            //
            // int num1 = int.Parse(Console.ReadLine());
            // int num2 = int.Parse(Console.ReadLine());
            // int num3 = int.Parse(Console.ReadLine());
            //
            // Console.WriteLine("amount of numbers " + (num1 + num2 + num3));
            // Console.WriteLine("multiply of numbers " + (num1 * num2 * num3));
            Console.WriteLine("choose the number currency for purchase:\n" +
                              "dollar -- 1\n" +
                              "euro ---- 2\n" +
                              "zloty --- 3");
            int currency1 = int.Parse(Console.ReadLine());
            Console.WriteLine($"currency for purchase {currency1}");

            Console.WriteLine("choose the number currency for sell:\n" +
                              "dollar -- 1\n" +
                              "euro ---- 2\n" +
                              "zloty --- 3");
            int currency2 = int.Parse(Console.ReadLine());
            Console.WriteLine($"currency for sell {currency2}");

            Console.WriteLine("type amount");
            double amount = double.Parse(Console.ReadLine());

            double result;
            if (currency1 == 1 && currency2 == 2) result = amount * 1.1;
            else if (currency1 == 1 && currency2 == 3) result = amount * 4.4;
            else result = amount * 4.9;

            Console.WriteLine($"currency exchange result -- {result}");
        }
    }
}