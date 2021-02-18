using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public delegate void MyDelegate(string text);
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
        public event MyDelegate Messenger;
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
        public Vehicle()
        {

        }
        public int CompareTo(Vehicle other)
        {
            return this.Price.CompareTo(other.Price);
        }
        public void Move()
        {
            Messenger?.Invoke("Bye Car!!!!");
            Console.WriteLine("Movement started");
        }
        public void EndMove()
        {
            Console.WriteLine("The movement is over");
        }
    }
}
