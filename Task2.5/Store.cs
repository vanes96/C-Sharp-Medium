using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    public static class Store
    {
        private static List<Good> _goods = new List<Good>();
        private static int _nextGoodId = 1;

        public static Good GetGood(int id)
        {
            try
            {
                Good good = _goods.Single(g => g.Id == id);

                if (good != null)
                    return good;
                else
                    throw new Exception("Недопустимое значение идентификатора!");
            }
            catch (Exception)
            {
                throw new Exception("Недопустимое значение идентификатора!");
            }
        }

        public static void ShowGoods()
        {
            Console.WriteLine("\nТовары\n======");

            foreach (var good in _goods)
                Console.WriteLine("{0})  {1}  {2}", good.Id, good.Name, good.Price);
        }

        public static void BuyGood(int id, bool pickup = false, int? discount = null)
        {
            Good good = GetGood(id);
            _goods.Remove(good);

            if (discount.HasValue)
            {
                good.UseDiscount(discount.Value);
                if (!pickup)
                    throw new Exception("Товар со скидкой доступен только для самовывоза!");
            }

            Console.WriteLine("\nКуплен товар\n======");
            Console.WriteLine("{0})  {1}  {2}  {3}  {4}", good.Id, good.Name, good.DiscountPrice ?? good.Price, discount != null ? $"Скидка {discount}%" : "Без скидки", pickup ? "Самовывоз" : "Доставка");
        }

        public static void AddGood(Good good)
        {
            good.Id = _nextGoodId;
            _goods.Add(good);
            _nextGoodId++;
        }

    }
}
