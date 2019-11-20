using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2._2
{
    class Program
    {
        static void Main(string[] _)
        {
            Console.WriteLine("Press any key..");
            while (Console.ReadKey().Key != ConsoleKey.Escape)
            {
                Console.Clear();
                Console.WriteLine("Please enter command");
                string commandName = Console.ReadLine();
                Command command;

                switch (commandName)
                {
                    case "open":
                        Console.WriteLine("Please enter your name");
                        try
                        {
                            command = new OpenCommand(Console.ReadLine());
                            Bank.DoCommand(command);
                            ShowSuccessMessage();
                        }
                        catch (Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    case "put":
                        Console.WriteLine("Please enter: \"accountId amount\"");
                        try
                        {
                            string[] commandInput = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            command = new PutCommand(int.Parse(commandInput[0]), int.Parse(commandInput[1]));
                            Bank.DoCommand(command);
                            ShowSuccessMessage();
                        }
                        catch (Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    case "get":
                        Console.WriteLine("Please enter: \"accountId amount\"");
                        try
                        {
                            string[] commandInput = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            command = new GetCommand(int.Parse(commandInput[0]), int.Parse(commandInput[1]));
                            Bank.DoCommand(command);
                            ShowSuccessMessage();
                        }
                        catch (Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    case "transfer":
                        Console.WriteLine("Please enter: \"senderId receiverId amount\"");
                        try
                        {
                            string[] transferInput = Console.ReadLine().Split(new string[] { " " }, StringSplitOptions.RemoveEmptyEntries);
                            command = new TransferCommand(int.Parse(transferInput[0]), int.Parse(transferInput[1]), int.Parse(transferInput[2]));
                            Bank.DoCommand(command);
                            ShowSuccessMessage();
                        }
                        catch(Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    case "close":
                        Console.WriteLine("Please enter account id");
                        try
                        {
                            command = new CloseCommand(int.Parse(Console.ReadLine()));
                            Bank.DoCommand(command);
                            ShowSuccessMessage();
                        }
                        catch(Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    case "undo":
                        try
                        {
                            Bank.UndoCommand();
                            ShowSuccessMessage();
                        }
                        catch(Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    case "show":
                        Console.WriteLine("Please enter account id");
                        try
                        {
                            int accountId = int.Parse(Console.ReadLine());
                            var account = Bank.GetAccount(accountId);
                            Console.WriteLine($"=================\n{account.Id} {account.OwnerName} {account.Balance}");
                        }
                        catch(Exception e)
                        {
                            ShowErrorMessage(e);
                        }
                        break;
                    default:
                        ShowErrorMessage(new Exception($"Command {commandName} does not exist"));
                        break;
                }
            }
        }

        static void ShowErrorMessage(Exception e)
        {
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine(e.Message);
            Console.ResetColor();
        }

        static void ShowSuccessMessage() 
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Command has been done.");
            Console.ResetColor();
        }
    }
}
