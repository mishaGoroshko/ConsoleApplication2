using System;
using System.Globalization;
using System.Runtime.CompilerServices;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Console.SetCursorPosition(10, 5);

            Console.WindowHeight = 20;
            Console.WindowWidth = 50;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();// console will set completely gray

            Console.WriteLine($"lorem lorem\nlorem lorem\nlorem lorem]\b \b");


            Console.ReadKey();
        }
    }
}