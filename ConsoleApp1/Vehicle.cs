using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public interface ICloneable
    {
        object Clone();
    }
    interface Irep
    {
        void Repairs();
    }
   public abstract class Vehicle:IComparable<Vehicle>
    {

        public int Price { get; set; }
        public int Brand { get; set; }
        public bool Serviceability { get; set; }
        public string Name { get; set; }
        public Vehicle(int price,bool service,string name)
        {
            Price = price;
            Serviceability = service;
            Name = name;
        }

        public int CompareTo(Vehicle other)
        {
            return this.Price.CompareTo(other.Price);
        }
    }
}
