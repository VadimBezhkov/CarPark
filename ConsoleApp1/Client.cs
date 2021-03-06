﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client : Person, ICloneable
    {
        EventLog myLog = new EventLog();

        public static EventLog systemPoolLog;
        public Car NameCar { get; set; }
        private List<Vehicle> affordable = new List<Vehicle>();
        public Parking<Vehicle> WhereMyCar { get; set; }
        public int Sum { get; set; }
        public Client(string lastName, string firstName, int Age, Gender gender, int sum) : base(lastName, firstName, Age, gender)
        {
            Sum = sum;
            systemPoolLog = new EventLog();
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName} LastName: {LastName} Age: {Age} Gender {(Gender)Gender} Sum: {Sum}";
        }
        public void SayToDispather(Dispather disp)
        {
            affordable.Clear();
            WhereMyCar = disp.thehnics;

            foreach (var teh in WhereMyCar.tehnics)
            {
                if (teh.Price <= Sum)
                    affordable.Add(teh);
            }

            ShowTeh();
        }
        public void ShowTeh()
        {
            foreach (var item in affordable)
            {
                Console.WriteLine(item);
            }
        }
        public void BuyCar(Dispather disp)
        {
            Console.WriteLine("Enter Car");
            string str = Console.ReadLine();
            Vehicle value=null;

            for (int i = 0; i < affordable.Count; i++)
            {
                var CurrentVeh = affordable[i];
               
                if (CurrentVeh.Name == str)
                {
                    value=CurrentVeh;
                    break;
                }
            }
            
            if (value != null)
            {
                value.Messenger += Go;
                value.Messenger += ShowSystem;
                value.Move();

                affordable.Remove(value);
                WhereMyCar.tehnics.Remove(value);
                Sum = Sum - value.Price;
                disp.Cassa = disp.Cassa + value.Price;
            }
        }
        public void Massage()
        {
            Console.WriteLine("Customer bought a car");
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        public void Go(string text)
        {
            Console.WriteLine("Bye this Car");
        }
        public void ShowSystem(string message)
        {
            if (!EventLog.SourceExists("Bye this Car"))
            {
                EventLog.CreateEventSource("Bye this Car", "My new Log");
                Console.WriteLine("Hello Alexey");
                Console.WriteLine("My Event posh log the system application");
                return;
            }

            systemPoolLog.Source = "Hello Alexey";

            systemPoolLog.WriteEntry(message);
        }
    }
}
