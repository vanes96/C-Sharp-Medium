using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Bank bank = new Bank();

            while(true)
            {
                Console.WriteLine("Please enter command..");
                string command = Console.ReadLine();
                
                switch(command)
                {
                    case "open":
                        Console.WriteLine("Please enter your name..");
                        bank.OpenAccount(Console.ReadLine());
                        break;
                    case "transfer":

                        break;
                    case "close":
                        Console.WriteLine("Please enter account id..");
                        bank.CloseAccout(int.Parse(Console.ReadLine()));
                        break;
                    case "undo":

                        break;
                }
            }
        }

    }
}
