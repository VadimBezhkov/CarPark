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
            Car a100 = new Car(200, true, BrandСar.Audi);
            Car a80 = new Car(250, true, BrandСar.Audi);
            Parking <Car> sts = new Parking<Car>(a100,a80);
            sts.Show();
            Console.ReadKey();
        }
    }
}
