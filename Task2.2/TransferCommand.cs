using System;
using System.Collections.Generic;
using System.Linq;

namespace Task2._2
{
    public class TransferCommand : Command
    {
        public int ReceiverId { get; private set; }
        public int Amount { get; private set; }

        public override void Do(ref List<Account> accounts)
        {
            try
            {
                accounts.Single(a => a.Id == AccountId).TakeMoney(Amount);
                accounts.Single(a => a.Id == ReceiverId).PutMoney(Amount);
            }
            catch (Exception e)
            {
                throw e;
            }
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
