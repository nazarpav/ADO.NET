using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _13._02._2020F
{
    class menuElement
    {
        public readonly int number;
        string data;
        public menuElement(int number,string data)
        {
            this.number = number;
            this.data = data;
        }

        public string Data { get => data;}

        public override string ToString()
        {
            return number.ToString() + " | " + data;
        }
    }
}
