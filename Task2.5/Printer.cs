using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    public class Printer : Good
    {
        public int CartridgeNumber { get; private set; }

        public Printer(string name, int price, int cartridgeNumber) : base(name, price)
        {
            if (cartridgeNumber > 0 && cartridgeNumber < 1000)
                CartridgeNumber = cartridgeNumber;
            else
                throw new Exception("Недопустимый номер картриджа!");
        }
    }
}
