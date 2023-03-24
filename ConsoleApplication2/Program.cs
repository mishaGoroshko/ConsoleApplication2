using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int name = Convert.ToInt32(Console.ReadLine());

            while (name-- > 1)
            {
                Console.WriteLine(name);
            }
        }
    }
}