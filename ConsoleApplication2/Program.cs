using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Queue<string> cicles = new Queue<string>();
            cicles.Enqueue("bmw");
            cicles.Enqueue("aprilia");
            cicles.Enqueue("honda");

            Console.WriteLine("Dequeue = return + remove\n" + cicles.Dequeue());
            Console.WriteLine("Peek = return\n" + cicles.Peek());

            Console.WriteLine("------------------");

            foreach (string cicle in cicles)
            {
                Console.WriteLine(cicle);
            }
        }
    }
}