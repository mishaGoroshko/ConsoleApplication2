using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Aydi newCar = new Aydi("SQ8", 120, 250);
            Console.WriteLine($"name: {newCar.Name}\n" +
                              $"speed: {newCar.Speed}\n" +
                              $"max speed: {newCar.MaxSpeed}");
        }
    }

    class Car
    {
        public string Name;
        public int Speed;

        public Car(string name, int speed)
        {
            Name = name;
            Speed = speed;
        }
    }

    class Aydi : Car
    {
        public int MaxSpeed;

        public Aydi(string name, int speed, int maxSpeed) : base(name, speed)
        {
            MaxSpeed = maxSpeed;
        }
    }
}