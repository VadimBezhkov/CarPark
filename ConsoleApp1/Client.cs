using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client : Person
    {
        public int sum { get; set; }
        public Client(string lastName, string firstName, int Age, Gender gender) : base(lastName, firstName, Age, gender)
        {
        }

    }
}
