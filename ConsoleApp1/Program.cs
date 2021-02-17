using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Operation
    {
        BecomeAClient=1,
        ShowAllVehicle,
        SortByPrice,
        ShowClients,
        BuyTechniks
    }
    public interface IShowMenu
    {
       void ShowMenu();
    }
    class Program:IShowMenu
    {
        static void Main(string[] args)
        {
            Dispather ivanov = new Dispather("Ivanov", "Sergey", 29, Gender.man, 5);
            CollectionClients(ivanov);
            while (true)
            {
                Program my = new Program();

                var list = my.CollectionVehicle();
                my.ShowMenu();
             

                Operation op;
                Enum.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    case Operation.BecomeAClient:
                        {
                            var fulname = AddNameClient();
                            AddMyClient(ivanov,fulname.Item1,fulname.Item2);
                        }
                        break;
                    case Operation.ShowAllVehicle:
                        {
                            list.Show();
                        }
                        break;
                    case Operation.SortByPrice:
                        {
                            list.tehnics.Sort();
                            list.Show();
                        }
                        break;
                    case Operation.BuyTechniks:
                        {
                            var fulname = AddNameClient();
                            Client CurrentUser = null;
                            foreach (var item in ivanov.client)
                            {
                                if (item.FirstName == fulname.Item1 && item.LastName == fulname.Item2)
                                    CurrentUser = item;
                                break;
                            }
                            if (CurrentUser != null)
                            {
                                CurrentUser.BuyCar(ivanov);
                            }
                            else
                            {
                                Client client = AddMyClient(ivanov, fulname.Item1, fulname.Item2);
                                client.BuyCar(ivanov);
                            }
                        }
                        break;
                    case Operation.ShowClients:
                        {
                            ivanov.ShowClients();
                        }
                        break;
                    default:
                        break;
                }

                Console.WriteLine();


                

                //var ivanov = my.CollectionClients();
                //ivanov.ShowClients();
                //ivanov.thehnics = list;

                //list.tehnics.Sort();
                //list.Show();
                //list.tehnics.Sort();
                //Console.Clear();

                ////ivanov.CheckServiceability();
                //list.tehnics.Sort();
                //Console.WriteLine(ivanov.Cassa);
                //list.Show();
            }
        }

        public void ShowMenu()
        {
            Console.WriteLine("My HomeWork");
            Console.WriteLine("by Vadim Bezhkov \n \n \n");
            Console.WriteLine("Become a client");
            Console.WriteLine("Show All Vehicle");
            Console.WriteLine("Sort by price");
            Console.WriteLine("Show Clients");
            Console.WriteLine("Buy technics ");
        }
        public Parking<Vehicle> CollectionVehicle()
        {
            Car a100 = new Car(3100, true, BrandСar.Audi, "a100");
            Car a80 = new Car(4250, true, BrandСar.Audi, "a80");
            Car a4 = new Car(5700, true, BrandСar.Audi, "a4");
            Car a6 = new Car(6300, true, BrandСar.Audi, "a6");
            Car a8 = new Car(4050, false, BrandСar.Audi, "a8");
            Car Golf = new Car(6500, true, BrandСar.Volkswagen, "6");
            Car v40 = new Car(4290, true, BrandСar.Volvo, "v40");
            Car a8a = (Car)a8.Clone();

            a8a.Price = 4000;
            a8a.Serviceability = true;

            Parking<Vehicle> sts = new Parking<Vehicle>(a100, a80, a6, a8, a4, a8a, Golf);
            //Parking<Car> sts1 = new Parking<Car>(new List<Car> { a100, a80, a6, a8, a4, a8a });
            sts.Addtehnics(v40);
            return sts;
        }
        public static void CollectionClients(Dispather name)
        {
            Client cli = new Client("Mishael", "Saha", 22, Gender.man, 15000);
            Client cli1 = new Client("Furst", "Mistik", 18, Gender.woman, 200);
            Client cli2 = new Client("Chelyadko", "Alexey", 27, Gender.man, 7000);
            Client cli3 = (Client)cli1.Clone();

            cli3.Age = 22;
            cli3.FirstName = "Nivarov";
            cli3.Gender = (int)Gender.man;

            
            name.AddClient(cli);
            name.AddClient(cli1);
            name.AddClient(cli2);
            name.AddClient(cli3);
        }
        public static Client AddMyClient(Dispather disp,string firstname, string lastname)
        {
            int Age;
            int Summ;
            Console.WriteLine("Enter Age");
            int.TryParse(Console.ReadLine(), out Age);

            Console.WriteLine("Gender");
            Gender gender;

            Enum.TryParse(Console.ReadLine(), out gender);
            Console.WriteLine("Enter Summ");

            int.TryParse(Console.ReadLine(), out Summ);

            Client client = new Client(firstname, lastname, Age, gender, Summ);
            disp.AddClient(client);
            Console.WriteLine($"Hello {lastname},{firstname}");
            return client;
        }
        public static (string,string) AddNameClient()
        {
            Console.WriteLine("Enter FirstName");
            var str = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            var str1 = Console.ReadLine();
            return (str, str1);
        }
    }
}
