﻿using System;
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
    class Car : Vehicle
    {
        public Car(int price, bool service,BrandСar brand) : base(price, service)
        {
            Brand = (int)brand;
            
        }
        public override string ToString()
        {
            return $"Price: {Price} On the run {Serviceability} Brand {(BrandСar)Brand}";
        }
    }
}