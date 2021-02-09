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
            Client cli = new Client("sadasd", "asdasdasd", 12,Gender.man,100);
            Console.WriteLine(cli.ToString());
            Client cli1 = new Client("sadasd", "asdasdasd", 18, Gender.woman, 200);
            Console.WriteLine(cli1.ToString());
            Car a100 = new Car(100, true, BrandСar.Audi,"a100");
            Car a80 = new Car(250, true, BrandСar.Audi, "a80");
            Car a4 = new Car(700, true, BrandСar.Audi, "a4");
            Car a6 = new Car(300, true, BrandСar.Audi, "a6");
            Car a8 = new Car(50, false, BrandСar.Audi, "a8");
            Car a8a = (Car)a8.Clone();
            a8a.Price = 400;
            a8a.Serviceability = true;
            Parking <Car> sts = new Parking<Car>(a100,a80,a6,a8,a4,a8a);
            sts.tehnics.Sort();
            sts.Show();
            Console.ReadKey();
        }
    }
}
