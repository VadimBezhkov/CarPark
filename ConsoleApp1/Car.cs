using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum BrandСar
    {
        Volvo,
        Audi,
        Mersedes,
        LandRower,
        Opel,
        Ford,
        Lada,
        Mazda,
        Nissan,
        BMW,
        Bentley,
        Cadilac,
        Chevrolet,
        Ferrari,
        Infinity,
        Lexus,
        Maserati,
        Lotus,
        Tesla,
        Skoda
    }

    class Car : Vehicle, ICloneable
    {
        public Car(int price, bool service,BrandСar brand,string name) : base(price, service,name)
        {
            Brand = (int)brand;
            
        }
        public override string ToString()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(new string('-', 60));
            Console.ResetColor();
            return $"Name: {Name}|  Brand: {(BrandСar)Brand}| Price: {Price}| On the run: {Serviceability} ";
        }
        //public object Clone()
        //{
        //    return new Car(Price, Serviceability, (BrandСar)Brand, Name);
        //}
        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
