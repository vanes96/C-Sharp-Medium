using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class TransferCommand : Command
    {
        public int ReceiverId { get; private set; }
        public int Amount { get; private set; }

        public override void Execute(ref List<Account> accounts)
        {
            if (accounts.Single(a => a.Id == AccountId).GetMoney(Amount))
            {
                accounts.Single(a => a.Id == ReceiverId).PutMoney(Amount);
                Console.WriteLine("Операция выполнена успешно");
            }
            else
                Console.WriteLine("Невозможно осуществить перевод средств");
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
