using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Cars : Vehicle
    {
        public Cars(int price, string brand, bool service) : base(price, brand, service)
        {
        }
    }
}
