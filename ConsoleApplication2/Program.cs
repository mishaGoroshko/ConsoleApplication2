using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine(Sum(2, 4));
            Console.WriteLine(Sum(2, word: "abc"));
        }

        static string Sum(int a, int b = 100, string word = "qwerty")
        {
            return a + b + word;
        }
    }
}