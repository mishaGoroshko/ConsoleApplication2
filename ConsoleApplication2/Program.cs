using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Aydi newCar = new Aydi();

            newCar.Name = "SQ8";
            newCar.Speed = 120;
            newCar.MaxSpeed = 250;
            
            Console.WriteLine($"name: {newCar.Name}\n" +
                              $"speed: {newCar.Speed}\n" +
                              $"max speed: {newCar.MaxSpeed}");
        }
    }

    class Car
    {
        public string Name;
        public int Speed;
    }

    class Aydi : Car
    {
        public int MaxSpeed;
    }
}