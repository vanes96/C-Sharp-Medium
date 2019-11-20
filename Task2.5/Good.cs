using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    public abstract class Good
    {
        public int Id { get; }
        public string Name { get; }
        public int Price { get; }       
        public int? DiscountPrice { get; private set; }

        public Good(string name, int price)
        {
            Id = Store.NextGoodId;
            DiscountPrice = null;

            if (string.IsNullOrWhiteSpace(name))
                throw new Exception("Wrong name!");
            else
                Name = name;

            if (price > 0)
                Price = price;
            else
                throw new Exception("Wrong price!");
        }

        public void UseDiscount(int discount)
        {
            if (discount >= 0 && discount <= 100)
                DiscountPrice = (int)Math.Round(Price - Price * discount / 100f);
            else
                throw new Exception("Wrong discount");
        }       
    }
}
