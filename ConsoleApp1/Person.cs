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
        private int age;
        public int Age
        {
            get => age;
            set
            {
                if (Age < 120 && Age > 0)
                {
                    age = value;
                }
                else
                    Console.WriteLine($"{LastName} Incorected Age");
            }
        }

        public byte Gender { get; set; }
        public Person(string lastName, string firstName, int Age, Gender gender)
        {
            LastName = lastName;
            FirstName = firstName;
            this.Age=Age;
            Gender = (byte)gender;
            
        }
    }
}
