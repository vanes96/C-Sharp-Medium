using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    public class Good
    {
        public string Name { get;}
        public int Price { get;}
        public int Level { get;}

        public Good(string name, int price, int level)
        {
            Name = name;
            Price = price;
            Level = level;
        }
    }
}
