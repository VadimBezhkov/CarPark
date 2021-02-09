using System;
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

        public void AddClient(Client client)
        {
            this.client.Add(client);
        }
        private int cassa;

        public int Cassa
        {
            get { return cassa; }
            set { cassa = value; }
        }
        public int WorkExperience { get; set; }

        public Parking<Vehicle> thehnics { get; set; }
        public Dispather(string lastName, string firstName, int Age, Gender gender,int work)
            : base(lastName, firstName, Age, gender)
        {
            WorkExperience = work;
        }
        public void ShowClients()
        {
            foreach (var myclaent in client)
            {
                Console.WriteLine(myclaent.ToString());
            }
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName} LastName: {LastName} Age:" +
                $" {Age} Gender {(Gender)Gender} Work Experience: {WorkExperience}";
        }
    }
}
