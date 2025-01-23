using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Oop_3_2.Class
{
    public class Car
    {
        public string Model { get; set; }
        public string Brand { get; set; }
        public decimal Price { get; set; }

        public Car(string brand, string model, decimal price)
        {
            Model = model;
            Brand = brand;
            Price = price;
        }
    }
}