using System;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int res = 0, a = 1, b = 4;
            Sum(a, b, ref res);
            Console.WriteLine(res);

            int res2, a2 = 1, b2 = 4;
            Sum2(a2, b2, out res2);
            Console.WriteLine(res);

            int[] arr = new int[5];
            int i = 2, value = 42;
            ChangeArray(arr, i, value);
            Console.WriteLine(arr[2]);
        }

        static int Sum(int a, int b, ref int res)
        {
            return res = a + b;
        }

        static int Sum2(int a, int b, out int res)
        {
            return res = a + b;
        }

        static void ChangeArray(int[] arr, int index, int value)
        {
            arr[index] = value;
        }
    }
}