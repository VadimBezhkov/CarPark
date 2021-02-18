using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // create delegate
    public delegate void MyDelegate1();
    enum Operation
    {
        BecomeAClient = 1,
        ShowAllVehicle,
        SortByPrice,
        ShowClients,
        BuyTechniks,
        AddTehnics,
        DeleteTehnics,
        TetsDrive
    }
    //create interface Menu
    public interface IShowMenu
    {
        void ShowMenu();
    }
    class Program : IShowMenu
    {
        // create system event
        public static EventLog systemPoolLog;
        public static void ShowSystem(string message)
        {
            if (!EventLog.SourceExists("MyPoolLog"))
            {
                EventLog.CreateEventSource("MyPoolLog", "PoolLog");
            }

            systemPoolLog.Source = "MyPoolLog";

            systemPoolLog.WriteEntry(message);
        }
        static void Main(string[] args)
        {
            //method communicated with delegate
            void TestDrive(string text)
            {
                Console.WriteLine("I'll start the engine");
                Console.WriteLine("The movement is over");
            }

            //create dispether
            Dispather ivanov = new Dispather("Ivanov", "Sergey", 29, Gender.man, 5);
            CollectionClients(ivanov);

            //create collection car
            Program my = new Program();
            var list = my.CollectionVehicle();

            while (true)
            {
                ivanov.thehnics = list;

                //create delegate menu
                MyDelegate1 Menu = new MyDelegate1(my.ShowMenu);

                //delegate invocation
                Menu?.Invoke();

                //menu selection
                Operation op;
                Enum.TryParse(Console.ReadLine(), out op);
                switch (op)
                {
                    //Become A Client
                    case Operation.BecomeAClient:
                        {
                            var fulname = AddNameClient();
                            AddMyClient(ivanov, fulname.Item1, fulname.Item2);
                        }
                        break;

                    //Show All Vehicle
                    case Operation.ShowAllVehicle:
                        {
                            list.Show();
                        }
                        break;

                    //Sort By Price
                    case Operation.SortByPrice:
                        {
                            list.tehnics.Sort();
                            list.Show();
                        }
                        break;

                    //Buy Car
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
                                CurrentUser.SayToDispather(ivanov);
                                CurrentUser.BuyCar(ivanov);
                            }
                            else
                            {
                                Client client = AddMyClient(ivanov, fulname.Item1, fulname.Item2);
                                client.SayToDispather(ivanov);
                                client.BuyCar(ivanov);

                            }
                        }
                        break;

                    //Show Clients
                    case Operation.ShowClients:
                        {
                            ivanov.ShowClients();

                        }
                        break;

                    //Add Car
                    case Operation.AddTehnics:
                        {
                            list.Show();
                            Car mycar = AddMyCar();
                            list.Addtehnics(mycar);
                            Console.WriteLine($"Add car {mycar.Name}");
                            list.Show();
                        }
                        break;

                        //Delete Car MyCollection
                    case Operation.DeleteTehnics:
                        {
                            list.Show();
                            Console.WriteLine("Enter name Car");
                            string str = Console.ReadLine();
                            Vehicle CurentCount = null;
                            foreach (var item in list.tehnics)
                            {
                                if (item.Name == str)
                                    CurentCount = item;
                            }
                            list.tehnics.Remove(CurentCount);
                            list.Show();
                        }
                        break;

                    //Take a car for a test drive
                    case Operation.TetsDrive:
                        {
                            list.Show();
                            Console.WriteLine("select a car");
                            string str = Console.ReadLine();
                            foreach (var item in list.tehnics)
                            {
                                if (item.Name == str)
                                {
                                    Console.WriteLine(item.ToString());
                                    Car myCar = new Car();
                                    myCar = item as Car;
                                    myCar.Drive += TestDrive;
                                    systemPoolLog = new EventLog();
                                    myCar.Drive += ShowSystem;
                                    myCar.Start();
                                }
                            }  
                        }
                        break;

                    default:
                        break;
                }
                Console.WriteLine();
            }
        }
        public void ShowMenu()
        {
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.WriteLine(new string(' ', 120));
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("My Homework");
            Console.ResetColor();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Become a client - press 1");
            Console.WriteLine("Show All Vehicle - press 2");
            Console.WriteLine("Sort by price - press 3");
            Console.WriteLine("Show Clients - press 4");
            Console.WriteLine("Buy technics - press 5");
            Console.WriteLine("Add technics - press 6");
            Console.WriteLine("Delete technics - press 7");
            Console.WriteLine("Test Drive - press 8");
            Console.ResetColor();
        }

        //create collection car hardcor
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

        //create collection client hardcor
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
        public static Client AddMyClient(Dispather disp, string firstname, string lastname)
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
        //First Name and List Name my Client
        public static (string, string) AddNameClient()
        {
            Console.WriteLine("Enter FirstName");
            var str = Console.ReadLine();
            Console.WriteLine("Enter LastName");
            var str1 = Console.ReadLine();
            return (str, str1);
        }
        //New Car
        public static Car AddMyCar()
        {
            int summ;
            bool servise;
            BrandСar brand;
            Console.WriteLine("Enter Summ");
            int.TryParse(Console.ReadLine(), out summ);
            Console.WriteLine("On The Go Or Not");
            bool.TryParse(Console.ReadLine(), out servise);
            Console.WriteLine("Enter Brend");
            Enum.TryParse(Console.ReadLine(), out brand);
            Console.WriteLine("Enter Name");
            string name = Console.ReadLine();
            Car car = new Car(summ, servise, brand, name);
            return car;
        }
    }
}
