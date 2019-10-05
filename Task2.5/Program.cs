using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Store.AddGood(new Phone("Iphone_8", 50000, 5.5f));
            Store.AddGood(new Printer("Hp_500", 5600, 178));

            Store.ShowGoods();

            try
            {
                Store.BuyGood(1, true, 33);
            }
            catch(Exception e)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine(e.Message);
                Console.ResetColor();
            }

            Store.ShowGoods();

            Console.ReadKey();
        }
    }
}
