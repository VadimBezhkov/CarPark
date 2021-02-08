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
            Client cli = new Client("sadasd", "asdasdasd", 12,Gender.man);
            Console.WriteLine($"") ;
            Console.ReadKey();
        }
    }
}
