﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics.Entities
{
    class Product : IComparable
    {
        public string Name { get; set; }
        public double Price { get; set; }

        public Product(string name, double price)
        {
            Name = name;
            Price = price;
        }

        public override string ToString()
        {
            return Name + ", " + Price;
        }

        public int CompareTo(object? obj)
        {
            if (!(obj is Product))
            {
                throw new ArgumentException("não é um produto");
            }
            Product other = (Product)obj;
            return Price.CompareTo(other.Price);
        }
    }
}
