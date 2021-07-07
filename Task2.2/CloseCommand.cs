using System;
using System.Collections.Generic;

namespace Task2._2
{
    public class CloseCommand : Command
    {
        private string OwnerName { get; }

        public override void Do()
        {
            Bank.CloseAccount(AccountId);
        }

        public override void Undo()
        {
            Bank.OpenAccount(OwnerName);
        }

        public CloseCommand(int accountId)
        {
            OwnerName = Bank.GetAccount(accountId).OwnerName;
            AccountId = accountId;
            Name = "close";
        }
    }
}
