using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    public abstract class Good
    {
        private int _id = 0;

        public int Id
        {
            get
            {
                if (_id > 0)
                    return _id;
                else
                    throw new Exception("Идентификатор не задан!");
            }
            set
            {
                if (value > 0 && _id == 0)
                    _id = value;
                else
                    throw new Exception("Недопустимое значение идентификатора либо он уже задан!");
            }
        }
        public string Name { get; private set; }
        public int Price { get; private set; }       
        public int? DiscountPrice { get; private set; }

        public Good(string name, int price)
        {
            DiscountPrice = null;
            SetName(name);
            SetPrice(price);
        }

        public void UseDiscount(int discount)
        {
            if (discount >= 0 && discount <= 100)
                DiscountPrice = (int)Math.Round(Price - Price * discount / 100f);
            else
                throw new Exception("Недопустимое значение скидки");
        }

        private void SetPrice(int price)
        {
            if (price > 0)
                Price = price;
            else
                throw new Exception("Недопустимое значение цены!");
        }

        private void SetName(string name)
        {
            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Недопустимое имя!");
            else
                Name = name;
        }
        
    }
}
