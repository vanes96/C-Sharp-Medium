using System;

namespace Task2._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Store.AddGood(new Phone("Iphone_8", 50000, 5.5f));
            Store.AddGood(new Printer("Hp_500", 5600, 178));

            Console.WriteLine("Press any key..");
            while(Console.ReadKey(true).Key != ConsoleKey.Escape)
            {
                Store.ShowGoods();
                Console.WriteLine("Enter good Id to buy:");
                int goodId;

                try
                {
                    if (!int.TryParse(Console.ReadLine(), out goodId))
                    {
                        throw new Exception("Wrong id!");
                    }
                    else if (Store.FindId(goodId))
                    {
                        Console.WriteLine("Enter discount from 0 to 100 if it is needed:");
                        int discount = -1;
                        string discountString = Console.ReadLine();

                        if (!string.IsNullOrWhiteSpace(discountString))
                        {
                            if (!int.TryParse(discountString, out discount))
                                throw new Exception("Wrong discount!");
                        }

                        Console.WriteLine("Will be pickup?: y/n");
                        string pickupString = Console.ReadLine();
                        bool pickup = false;

                        if (pickupString == "y")
                            pickup = true;
                        else if (pickupString == "n")
                            pickup = false;
                        else
                            throw new Exception("Wrong command!");

                        if (discount == -1)
                            Store.BuyGood(goodId, pickup);
                        else
                            Store.BuyGood(goodId, pickup, discount);
                    }
                    else
                        throw new Exception("Wrong id!");
                }              
                catch (Exception e)
                {
                    ShowExceptionMessage(e);
                }                                           
            }
        }

        static void ShowExceptionMessage(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }
    }
}
