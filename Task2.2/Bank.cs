using System;
using System.Collections.Generic;

namespace Task2._2
{
    static class Bank
    {
        public static List<Command> Commands { get; private set; }
        public static List<Account> Accounts { get; private set; }


        public static void AddCommand(Command command)
        {
            Commands.Add(command);
        }

        public static void CreateAccount(string ownerName)
        {
            Accounts.Add(new Account(Accounts.Count + 1, ownerName));
        }
    }
}
