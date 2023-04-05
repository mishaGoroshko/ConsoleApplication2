using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Address address = new Address("B1-3029", "Gdynia", "Poland");
            Employee employee = new Employee(1001, "Mika", address);
            employee.Display();
            Console.ReadKey();
        }
    }
    
    class Address
    {
        public string AddressLine, City, State;
        public Address(string addressLine, string city, string state)
        {
            AddressLine = addressLine;
            City = city;
            State = state;
        }
    }
    class Employee
    {
        //Using Address in Employee class
        //Establishing Has-A relationship i.e. Employee HAS-A Address   
        public Address address; 
        public int Id;
        public string Name;
        public Employee(int id, string name, Address adrs)
        {
            Id = id;
            Name = name;
            address = adrs;
        }
        public void Display()
        {
            Console.WriteLine($"Employee Id: {Id}");
            Console.WriteLine($"Employee Name: {Name}");
            Console.WriteLine($"AddressLine: {address.AddressLine}");
            Console.WriteLine($"City: {address.City}");
            Console.WriteLine($"State: {address.State}");
        }
    }
}