using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[4] { 1, 2, 3, 4 };
            int[] extraArr = new int[5];

            for (int i = 0; i < arr.Length; i++)
            {
                extraArr[i] = arr[i];
            }

            arr = extraArr;

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }

            Console.WriteLine("------------------");

            int[] arr2 = new int[4] { 1, 2, 3, 4 };

            Array.Resize(ref arr2, 5);

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}