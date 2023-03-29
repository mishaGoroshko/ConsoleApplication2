using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Stack<int> numbers = new Stack<int>();

            numbers.Push(1);
            numbers.Push(2);
            numbers.Push(3);
            numbers.Push(4);
            numbers.Push(5);

            Console.WriteLine("first out number - " + numbers.Peek());

            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }

            while (numbers.Count > 0)
            {
                Console.WriteLine($"next removed number is {numbers.Pop()}");
            }
        }
    }
}