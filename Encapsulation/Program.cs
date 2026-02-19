using System;

namespace Encapsulation
{
    public class Product
    {
        private string _name;
        private int _price;

        public string Name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }

        public int Price
        {
            get
            {
                return _price;
            }
            set
            {
                if (value > 0)
                {
                    _price = value;
                }
            }
        }
    }


    class Program
    {
        public static void GetProductInfo(string name, int price)
        {
            Console.WriteLine($"{name}: {price}");
        }
        public static void Main(string[] args)
        {
            Product p1 = new Product();
            p1.Name = "Laptop";
            p1.Price = 100;
            GetProductInfo(p1.Name, p1.Price);
        }
    }

    
}

