using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            // int name = Convert.ToInt32(Console.ReadLine());
            //
            // while (name-- > 1)
            // {
            //     Console.WriteLine(name);
            // }
            //
            // Random rand = new Random();


            // while (true)
            // {
            //     int num = rand.Next(0, 5);
            //     Console.WriteLine(num);
            //     Console.ReadKey();
            // }

            for (int i = 0; i < 5; i++)
            {
                Random rand2 = new Random();
                Console.WriteLine(rand2.Next(0, 5));// all the same results
            }

            Console.WriteLine("----------------------");

            Random rand3 = new Random();

            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(rand3.Next(0, 5));//all different results
            }
        }
    }
}