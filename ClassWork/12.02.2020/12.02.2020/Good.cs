using System;
using System.Collections.Generic;
using System.Text;

namespace _12._02._2020
{
    class Good
    {
        public int Id;
        public string Title = String.Empty;
        public decimal Price;
        public string Category = String.Empty;
        public override string ToString()
        {
            return "Id" + Id + " Title" + Title + " Price" + Price + " Category" + Category;
        }
    }
}
