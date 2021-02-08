using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface Irep
    {
        void Repairs();
    }
    abstract class Vehicle
    {

        public int Price { get; set; }
        public string Brand { get; set; }
        public bool Serviceability { get; set; }
        public Vehicle(int price, string brand, bool service)
        {
            Price = price;
            Brand = brand;
            Serviceability = service;
        }
    }
}
