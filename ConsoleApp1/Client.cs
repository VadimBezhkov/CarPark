using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Client : Person,ICloneable
    {
        public int Sum { get; set; }
        public Client(string lastName, string firstName, int Age, Gender gender,int sum) : base(lastName, firstName, Age, gender)
        {
            Sum = sum;
        }
        public override string ToString()
        {
            return $"FirstName: {FirstName} LastName: {LastName} Age: {Age} Gender {(Gender)Gender} Sum: {Sum}";
        }
        public void SayToDispather(Dispather disp)
        {
            disp.client.Add(this);
        }
        public object Clone()
        {
            return this.MemberwiseClone();
        }
        
    }
}
