using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2._5
{
    public static class Store
    {
        private static List<Good> _goods = new List<Good>();
        public static int NextGoodId { get; private set; } = 1;

        public static bool FindId(int id)
        {
            var good = _goods.Find(g => g.Id == id);

            if (good == null)
                return false;
            else
                return true;
        }

        public static Good GetGood(int id)
        {
            Good good = _goods.Single(g => g.Id == id);

            if (good != null)
                return good;
            else
                throw new Exception("Wrong id!");
        }

        public static void ShowGoods()
        {
            Console.WriteLine("\nGoods\n======");

            foreach (var good in _goods)
                Console.WriteLine("{0})  {1}  {2}", good.Id, good.Name, good.Price);
            Console.WriteLine();
        }

        public static void BuyGood(int id, bool pickup = false, int? discount = null)
        {
            Good good = GetGood(id);

            if (discount.HasValue)
            {
                good.UseDiscount(discount.Value);
                if (!pickup)
                    throw new Exception("Discount good is available only for pickup!");
            }

            _goods.Remove(good);
            Console.WriteLine("\nGood has been bought\n======");
            Console.WriteLine("{0})  {1}  {2}  {3}  {4}", good.Id, good.Name, good.DiscountPrice ?? good.Price, discount != null ? $"Discount {discount}%" : "No discount", pickup ? "Pickup" : "Delivery");
        }

        public static void AddGood(Good good)
        {
            _goods.Add(good);
            NextGoodId++;
        }

    }
}
