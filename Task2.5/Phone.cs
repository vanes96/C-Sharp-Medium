using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    public class Phone : Good
    {
        public float ScreenSize { get; private set; }

        public Phone(string name, int price, float screenSize) : base(name, price)
        {
            if (screenSize > 0 && screenSize < 10)
                ScreenSize = screenSize;
            else
                throw new Exception("Недопустимый размер экрана!");
        }
    }
}
