using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Category
    { 
        A=1,B,C,
        D,M
       
    
    }
    class Driver : Person
    {
        public int Experience { get; set; }
        public Driver(string lastName, string firstName, int Age, Gender gender,int exsp) : base(lastName, firstName, Age, gender)
        {
            Experience = exsp;
        }
    }
}
