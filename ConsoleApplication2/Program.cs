using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication2
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Cart newCart = new Cart();
            newCart.ShowProduct();

            List<Product> newProduts = new List<Product>();

            for (int i = 0; i < newCart.GetProductCount(); i++)
            {
                newProduts.Add(newCart.GetProductByIndex(i));
            }
            
            newProduts.RemoveAt(3);//doesn't remove in newCart

            Console.WriteLine();
            newCart.ShowProduct();;
        }
    }

    class Cart
    {
        private List<Product> _products = new List<Product>();

        public Cart()
        {
            _products.Add(new Product("bread"));
            _products.Add(new Product("apple"));
            _products.Add(new Product("water"));
            _products.Add(new Product("milk"));
        }

        public void ShowProduct()
        {
            // for (int i = 0; i < products.Count; i++)
            // {
            //     Console.WriteLine(products[i].Name);
            // }
            foreach (Product product in _products)
            {
                Console.WriteLine(product.Name);
            }
        }

        public int GetProductCount()
        {
            return _products.Count;
        }

        public Product GetProductByIndex(int index)
        {
            return _products.ElementAt(index);
        }
    }

    class Product
    {
        public string Name { get; private set; }

        public Product(string name)
        {
            Name = name;
        }
    }
}