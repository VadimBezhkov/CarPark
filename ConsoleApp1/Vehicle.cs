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
        public int Brand { get; set; }
        public bool Serviceability { get; set; }
        public Vehicle(int price,bool service)
        {
            Price = price;
            Serviceability = service;
        }
    }
}
