using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Dispather : Person
    {
        public int SumKassa { get; set; }
        public Dispather(string lastName, string firstName, int Age, Gender gender) : base(lastName, firstName, Age, gender)
        {
        }
    }
}
