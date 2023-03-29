using System;
using System.Collections.Generic;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Dictionary<string, string> countries = new Dictionary<string, string>();

            countries.Add("Poland", "Warsaw");
            countries.Add("Germany", "Berlin");
            countries.Add("UK", "London");

            countries.Remove("UK");

            if (countries.ContainsKey("Poland")) Console.WriteLine(countries["Poland"]);

            foreach (var item in countries)
            {
                Console.WriteLine(item);
                Console.WriteLine(item.Key);
                Console.WriteLine(item.Value);
            }

            foreach (var country in countries.Keys)
            {
                Console.WriteLine(country);
            }

            foreach (var capital in countries.Values)
            {
                Console.WriteLine(capital);
            }
        }
    }
}