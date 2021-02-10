using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            Client cli = new Client("sadasd", "asdasdasd", 12,Gender.man,15000);
            Client cli1 = new Client("sadasd", "asdasdasd", 18, Gender.woman, 200);
            Client cli2 = new Client("Chelyadko", "Alexey", 27, Gender.man, 7000);
            Client cli3 = (Client)cli1.Clone();
            cli3.Age = 22;
            cli3.FirstName = "Nivarov";
            cli3.Gender = (int)Gender.man;

            Dispather ivanov = new Dispather("Ivanov", "Sergey", 29, Gender.man,5);
            ivanov.AddClient(cli);
            ivanov.AddClient(cli1);
            ivanov.AddClient(cli2);
            ivanov.AddClient(cli3);
            ivanov.ShowClients();
           

            Car a100 = new Car(100, true, BrandСar.Audi,"a100");
            Car a80 = new Car(250, true, BrandСar.Audi, "a80");
            Car a4 = new Car(700, true, BrandСar.Audi, "a4");
            Car a6 = new Car(300, true, BrandСar.Audi, "a6");
            Car a8 = new Car(50, false, BrandСar.Audi, "a8");
            Car Golf = new Car(6500, true, BrandСar.Volkswagen, "6");
            Car a8a = (Car)a8.Clone();
            a8a.Price = 400;
            a8a.Serviceability=true;

            Parking <Vehicle> sts = new Parking<Vehicle>(a100,a80,a6,a8,a4,a8a,Golf);
            ivanov.thehnics = sts;

            Car v40 = new Car(290, true, BrandСar.Volvo, "v40"); 
            sts.Addtehnics(v40);
            //Parking<Car> sts1 = new Parking<Car>(new List<Car> { a100, a80, a6, a8, a4, a8a });
            sts.tehnics.Sort();
            sts.Show();
            Console.Clear();

            cli2.SayToDispather(ivanov);
            cli2.ByCar(ivanov);
            Console.WriteLine(ivanov.Cassa);
            Console.WriteLine(cli.Sum);
            Console.WriteLine($"Congratulations on your purchase: {cli2.ToString()}");
            sts.Show();
            Console.ReadKey();
        }
    }
}
