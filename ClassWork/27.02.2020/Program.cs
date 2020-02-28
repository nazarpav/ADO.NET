using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopCodeFirst
{
    class Program
    {
        static void Main(string[] args)
        {
            Model1 m = new Model1();
            foreach (var i in m.Cities)
            {
                Console.WriteLine(i.Name);
            }
        }
    }
}
