using System;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr1 = { 1, 2, 3, int.MaxValue, int.MinValue };
            int[] arr2 = new int[4] { 1, 2, 3, 4 };
            int[] arr = new int[3];

            Random rand = new Random();

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = rand.Next(0, 11);
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("\n--------------------");

            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }

            Console.WriteLine("\n---------sum-----------");

            int[] arr3 = { 1, 3, 4 };
            int sum = 0;
            for (int i = 0; i < arr3.Length; i++)
            {
                sum += arr3[i];
            }

            Console.WriteLine(sum);

            Console.WriteLine("-----maximum number------");
            int maxNumber = int.MinValue;

            for (int i = 0; i < arr3.Length; i++)
            {
                if (maxNumber < arr3[i])
                {
                    maxNumber = arr3[i];
                }  
            }

            Console.WriteLine(maxNumber);
        }
    }
}