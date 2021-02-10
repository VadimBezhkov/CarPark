using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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
    class Dispather : Person, ICheck
    {
        public List<Client> client = new List<Client>();
        private List<Vehicle> veh = new List<Vehicle>();

        public void AddClient(Client client)
        {
            Console.WriteLine("Enter you name");
            string name =Console.ReadLine();

            for (int i = 0; i < this.client.Count; i++)
            {
                if (client.FirstName == name)
                    break;
                else
                    this.client.Add(client);
            }

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

        public void CheckServiceability()
        {

            for (int i = 0; i < thehnics.tehnics.Count; i++)
            {
                var serviceability = thehnics.tehnics[i];
                {
                    if (!serviceability.Serviceability)
                    {
                        veh.Add(serviceability);
                        thehnics.tehnics.Remove(serviceability);
                    }
                }
            }

            if (veh != null)
            {
                for (int i = 0; i < veh.Count; i++)
                {
                    if (veh[i] != null)
                    {
                        Console.Clear();
                        Console.WriteLine("Wait, repairing");
                        int time = 10;

                        for (int j=time; j > 0; j--)
                        {
                            Console.Write($"\r {new string (' ',50)}\rSeconds: {j}");
                            Thread.Sleep(1000);
                        }
                        Console.WriteLine("\rYou can take it back");
                        veh[i].Serviceability = true;
                        thehnics.tehnics.Add(veh[i]);
                        veh.Clear();
                    }
                }
            }
        }
    }
}
