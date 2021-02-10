using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client : Person, ICloneable
    {
        private List<Vehicle> affordable = new List<Vehicle>();
        public Parking<Vehicle> WhereMyCar { get; set; }
        public int Sum { get; set; }
        public Client(string lastName, string firstName, int Age, Gender gender, int sum) : base(lastName, firstName, Age, gender)
        {
            Sum = sum;
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName} LastName: {LastName} Age: {Age} Gender {(Gender)Gender} Sum: {Sum}";
        }
        public void SayToDispather(Dispather disp)
        {
            disp.client.Add(this);
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
        public void ByCar(Dispather disp)
        {
            Console.WriteLine("Enter Car");
            string str = Console.ReadLine();
            for (int i = 0; i < affordable.Count; i++)
            {
                var CurrentVeh = affordable[i];
                if (CurrentVeh.Name == str)
                {
                    affordable.Remove(CurrentVeh);
                    WhereMyCar.tehnics.Remove(CurrentVeh);
                    Sum = Sum - CurrentVeh.Price;
                    disp.Cassa = disp.Cassa + CurrentVeh.Price;
                    break;
                }
            }
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }  
    }
}
