using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            List<int> numbers = new List<int>(5);

            numbers.Add(11);
            numbers.Add(22);
            numbers.Add(33);
            numbers.Add(44);
            numbers.Add(55);

            numbers.AddRange(new int[] { 66, 77, 88 });

            numbers.Insert(3, 10000);

            for (int i = 0; i < numbers.Count; i++)
            {
                Console.WriteLine(numbers[i]);
            }

            numbers.RemoveAt(4);

            numbers.Remove(66);

            // numbers.Clear();

            foreach (var number in numbers)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine($"index of number 77 is {numbers.IndexOf(77)}");
        }
    }
}