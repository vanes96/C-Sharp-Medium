using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Good[] goods = new Good[] { new Good("Iphone_X", 95000, 1), new Good("HP_Pavilion", 85000, 2) };
       
            ShowGoods(goods);
            //IEnumerable<Good> sortedGoods;                    
            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.WriteLine("Sort by: 1-name or 2-price or 3-level");
                string commandNumber = Console.ReadLine();

                switch(commandNumber)
                {
                    case "1":
                        ShowGoods(goods.OrderBy(g => g.Name));
                        break;
                    case "2":
                        ShowGoods(goods.OrderBy(g => g.Price));
                        break;
                    case "3":
                        ShowGoods(goods.OrderBy(g => g.Level));
                        break;
                }
            }
        }

        static void ShowGoods(IEnumerable<Good> goods)
        {
            Console.WriteLine("Goods\n=====\n");

            int i = 1;
            foreach (var good in goods)
            {
                Console.WriteLine("{0}) Name: {1}  Price: {2}  Level: {3}", i, good.Name, good.Price, good.Level);
                i++;
            }

            Console.WriteLine("--------------------------------------------");
        }
    }
}
