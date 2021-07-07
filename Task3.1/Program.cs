using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Good[] goods = new Good[] { new Good("Смартфон_Iphone_X", 95000, 1), new Good("Ноутбук_HP_Pavilionwertdsd", 85000, 2),
                                        new Good("Бритва_scholl", 5400, 3)};
       
            ShowGoods(goods);           

            while (true)
            {
                Console.WriteLine("\nНажмите любую клавишу..");
                if (Console.ReadKey().Key == ConsoleKey.Escape)
                    break;
                Console.WriteLine("\nСортировать по: 1-названию или 2-цене или 3-уровню. Введите номер команды");

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
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine($"Команда {commandNumber} не существует!");
                        Console.ResetColor();
                        break;
                }
            }
        }

        static void ShowGoods(IEnumerable<Good> goods)
        {
            Console.WriteLine("\n{0, -1} | {1,-30} | {2,-10} | {3,-1}", "N", "Название", "Цена", "Уровень");
            Console.WriteLine("---------------------------------------------------------");

            int i = 1;
            foreach (var good in goods)
            {
                Console.WriteLine("{0, -1} | {1,-30} | {2,-10} | {3,-1}", i, good.Name, good.Price, good.Level);
                i++;
            }
        }
    }
}
