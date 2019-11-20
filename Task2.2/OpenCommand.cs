using System;
using System.Collections.Generic;

namespace Task2._2
{
    public class OpenCommand : Command
    {
        private string OwnerName { get; }

        public override void Do()
        {
            AccountId = Bank.OpenAccount(OwnerName);
        }

        public override void Undo()
        {
            Bank.CloseAccount(AccountId);
        }

        public OpenCommand(string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
                throw new Exception("Wrong owner name!");

            OwnerName = ownerName;
            Name = "open";
        }
    }
}
