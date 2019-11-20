using System;
using System.Collections.Generic;

namespace Task2._2
{
    public static class Bank
    {
        private static List<Command> Commands { get; set; } = new List<Command>();
        private static List<Account> Accounts { get; set; } = new List<Account>();


        public static void DoCommand(Command command)
        {
            command.Do();
            Commands.Add(command);
        }

        public static void UndoCommand()
        {
            Commands.FindLast(c => c.AccountId > 0).Undo();
            Commands.RemoveAt(Commands.Count - 1);
        }

        public static Account GetAccount(int id)
        {
            var account = Accounts.Find(a => a.Id == id);
            if (account != null)
                return account;
            else
                throw new Exception($"Account with Id = {id} does not exist");
        }

        public static void TakeMoney(int accountId, int amount)
        {
            GetAccount(accountId).TakeMoney(amount);
        }

        public static void PutMoney(int accountId, int amount)
        {
            GetAccount(accountId).PutMoney(amount);
        }

        public static int OpenAccount(string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
                throw new Exception("Wrong owner name");

            var newAccount = new Account(Accounts.Count + 1, ownerName);
            Accounts.Add(newAccount);
            return newAccount.Id;
        }

        public static void CloseAccount(int id)
        {
            if (Accounts.RemoveAll(a => a.Id == id) <= 0)
                throw new Exception($"Account with Id = {id} does not exist");
        }
    }
}
