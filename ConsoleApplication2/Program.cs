using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Table[] tables =
            {
                new Table(1, 10, 10),
                new Table(2, 20, 20),
                new Table(1, 30, 30)
            };

            for (int i = 0; i < tables.Length; i++)
            {
                tables[i].ShowProperties();
            }
        }
    }

    class Table
    {
        private int Number;
        private int MaxSeats;
        private int FreeSeats;

        public Table(int number, int maxSeats, int freeSeats)
        {
            Number = number;
            MaxSeats = maxSeats;
            FreeSeats = freeSeats;
        }

        public void ShowProperties()
        {
            Console.WriteLine($"Table number: {Number}\n" +
                              $"seats: free {FreeSeats} of max {MaxSeats}");
        }
    }
}