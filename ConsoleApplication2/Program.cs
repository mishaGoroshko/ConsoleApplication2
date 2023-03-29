using System;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] arr = new int[3];
            Resize(ref arr, 5);
            Console.WriteLine(arr.Length);
            
            int[,] arr2 = new int[2,3];
            Resize(ref arr2, 5, 5);
            Console.WriteLine(arr2.Length);
        }

        static void Resize(ref int[] arr, int newSize)
        {
            Array.Resize(ref arr, newSize);
        }

        static void Resize(ref int[,] arr, int rowSize, int columnSize)
        {
            int[,] tempArr = new int[rowSize, columnSize];
            for (int i = 0; i < arr.GetLength(0); i++)
            {
                for (int j = 0; j < arr.GetLength(1); j++)
                {
                    tempArr[i, j] = arr[i, j];
                }
            }

            arr = tempArr;
        }
    }
}