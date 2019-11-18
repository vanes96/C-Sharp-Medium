using System;
using System.Collections.Generic;
using System.Linq;

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
                Command command;


                switch (commandName)
                {
                    case "open":
                        Console.WriteLine("Please enter your name..");
                        try
                        {
                            command = new OpenCommand(Console.ReadLine());
                            command.Execute(ref accounts);
                            commands.Add(command);
                        }
                        catch (Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                        }

                        break;
                    case "put":

                        break;
                    case "get":

                        break;
                    case "transfer":
                        Console.WriteLine("Please enter: senderId receiverId amount..");
                        try
                        {
                            string[] transferInput = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            command = new TransferCommand(int.Parse(transferInput[0]), int.Parse(transferInput[1]), int.Parse(transferInput[2]));
                            command.Execute(ref accounts);
                            commands.Add(command);
                            
                        }
                        catch(Exception e)
                        {
                            Console.ForegroundColor = ConsoleColor.DarkRed;
                            Console.WriteLine(e.Message);
                            Console.ResetColor();
                        }
                        break;
                    case "close":
                        Console.WriteLine("Please enter account id..");
                        command = new CloseCommand(int.Parse(Console.ReadLine()));
                        commands.Add(command);
                        command.Execute(ref accounts);
                        break;
                    case "undo":
                        command = commands.Last();
                        Command undoCommand;

                        switch (command.Name)
                        {
                            case "open":
                                undoCommand = new CloseCommand(command.AccountId);
                                undoCommand.Execute(ref accounts);
                                break;
                            case "close":
                                undoCommand = new OpenCommand((command as OpenCommand).OwnerName);
                                undoCommand.Execute(ref accounts);
                                break;
                            case "undo":

                            break;
                        }

                        commands.Remove(command);
                        break;
                    default:
                        Console.WriteLine("Command {0} doesnt exist", commandName);
                        break;
                }
            }
        }

    }
}
