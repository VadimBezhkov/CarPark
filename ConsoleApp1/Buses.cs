using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Buses : Vehicle
    {
        public int CountPlace { get; set; }
        public Buses(int price, bool service) : base(price, service)
        {
        }
    }
}
