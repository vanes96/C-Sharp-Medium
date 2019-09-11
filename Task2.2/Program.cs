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
            List<Command> commands = new List<Command>();
            List<Account> accounts = new List<Account>();

            while(Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Please enter command..");
                string commandName = Console.ReadLine();
                Command command = null;

                switch (commandName)
                {
                    case "open":
                        Console.WriteLine("Please enter your name..");
                        command = new OpenCommand(Console.ReadLine());
                        commands.Add(command);
                        break;
                    case "transfer":

                        break;
                    case "close":
                        Console.WriteLine("Please enter account id..");
                        command = new CloseCommand(int.Parse(Console.ReadLine()));
                        commands.Add(command);
                        break;
                    case "undo":

                        break;
                    default:
                        Console.WriteLine("Command {0} doesnt exist", commandName);
                        break;
                }
            }
        }

    }
}
