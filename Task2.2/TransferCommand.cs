using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2._2
{
    public class TransferCommand : Command
    {
        private int ReceiverId { get; }
        private int Amount { get; }

        public override void Do()
        {
            new GetCommand(AccountId, Amount).Do();
            new PutCommand(ReceiverId, Amount).Do();
        }

        public override void Undo()
        {
            new GetCommand(AccountId, Amount).Undo();
            new PutCommand(ReceiverId, Amount).Undo();
        }

        public TransferCommand(int senderId, int receiverId, int amount)
        {
            AccountId = senderId;
            ReceiverId = receiverId;
            Amount = amount;
            Name = "transfer";
        }
    }
}
