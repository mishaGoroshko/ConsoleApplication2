using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[,] arr1 = new int[2, 3];
            int[,] arr2 = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
            int[,] arr3 = { { 1, 2, 3 }, { 4, 5, 6 } };

            for (int i = 0; i < arr3.GetLength(0); i++)
            {
                for (int j = 0; j < arr3.GetLength(1); j++)
                {
                    Console.Write(arr3[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------");

            int[,] arr4 = new int[3, 4];

            Random rand = new Random();

            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    arr4[i, j] = rand.Next(0, 10);
                    Console.Write(arr4[i, j] + " ");
                }

                Console.WriteLine();
            }

            Console.WriteLine("-----------------");

            foreach (var i in arr4)
            {
                Console.Write(i + " ");
            }
        }
    }
}