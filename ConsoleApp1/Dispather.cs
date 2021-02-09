﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    interface IVehicleDelivery:ISum,ICheck
    {
        void Issue();
    }
    interface ISum
    {
        void GetMoney();
    }
    interface ICheck
    {
        void CheckServiceability();
    }
    class Dispather : Person
    {
        public List<Client> client = new List<Client>();
        public int SumKassa { get; set; }
        public Parking<Vehicle> thehnics { get; set; }
        public Dispather(string lastName, string firstName, int Age, Gender gender) : base(lastName, firstName, Age, gender)
        {
        }
    }
}
