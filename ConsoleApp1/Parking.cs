using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public class Parking<T>
    {
        List<T> tehnics = new List<T>();
        public Parking(List<T> vehi)
        {
            tehnics.AddRange(vehi);
        }
        public Parking(params T[] vehi)
        {
            tehnics.AddRange(vehi);
        }
        public void Show()
        {
            foreach (var item in tehnics)
            {
                Console.WriteLine(item.ToString());
            }
        }
    }
}
