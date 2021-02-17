using System;

namespace ConsoleApp1
{
    enum Gender : byte
    {
        man, woman
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
                //age = value;
                if (value < 120 && value > 0)
                {
                    age = value;
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine($"{LastName} Incorected Age\n");
                    Console.ResetColor();
                }
            }
        }

        public byte Gender { get; set; }
        public Person(string lastName, string firstName, int Age, Gender gender)
        {
            LastName = lastName;
            FirstName = firstName;
            this.Age = Age;
            Gender = (byte)gender;

        }
    }
}
