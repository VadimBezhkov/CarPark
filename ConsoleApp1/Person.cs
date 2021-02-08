using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    enum Gender:byte
    {
        man,woman
    }
   abstract class Person
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public int Age { get; set; }
        public Person(string lastName, string firstName, int Age)
        {
            LastName = lastName;
            FirstName = firstName;
            this.Age = Age;
        }
    }
}
