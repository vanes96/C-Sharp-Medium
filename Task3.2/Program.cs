using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = new List<Product>();
            products.Add(new Product(1, "iPhoneX", 90, 3));
            products.Add(new Product(2, "Lenovo76", 45, 6));
            products.Add(new Product(3, "Whirlpool", 57, 15));

            var searchedProducts = products.Where(p => p.Price < 100 && p.Quantity > 5);

            Console.WriteLine("{0,-2}|{1,-15}|{2,-5}|{3,-3}\n-----------------------------------", "Id", "Название", "Цена", "Количество");
            foreach (var product in searchedProducts)
                Console.WriteLine("{0,-2}|{1,-15}|{2,-5}|{3,-3}", product.Id, product.Name, product.Price, product.Quantity);

            Console.ReadKey();
        }
    }
}
