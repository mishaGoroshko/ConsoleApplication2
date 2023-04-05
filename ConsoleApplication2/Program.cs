using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Car audi = new Car();
            // audi.Name = "SQ8";
            // audi.Power = 450;
            // audi.Age = 3;

            audi.ShowParams();
        }

        class Car
        {
            public string Name;
            public int Power;
            public int Age;
            private readonly int _vin = 82347123;

            public Car(string name, int power, int age)
            {
                Name = name;
                Power = power;
                Age = age;
            }

            public Car()
            {
            }


            public void ShowParams()
            {
                Console.WriteLine($"Name: {Name}\n" +
                                  $"Power: {Power}\n" +
                                  $"Age: {Age}\n" +
                                  $"VIN: {_vin}");
            }

            public void ChangeQuality(int lostAges, int lostHorses)
            {
                Age += lostAges;
                Power -= lostHorses;
            }

            public void ChangeQualityThis(int Age, int lostHorses)
            {
                this.Age += Age;
                Power -= lostHorses;
            }
        }
    }
}