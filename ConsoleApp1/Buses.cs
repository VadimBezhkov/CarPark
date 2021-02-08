using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Buses : Vehicle
    {
        public Buses(int price, string brand, bool service) : base(price, brand, service)
        {
        }
    }
}
