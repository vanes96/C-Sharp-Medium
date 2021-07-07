using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class GetCommand : Command
    {
        private int Amount { get; }

        public override void Do()
        {
            Bank.TakeMoney(AccountId, Amount);
        }

        public override void Undo()
        {
            Bank.PutMoney(AccountId, Amount);
        }

        public GetCommand(int accountId, int amount)
        {
            AccountId = accountId;
            Amount = amount;
            Name = "get";
        }
    }
}
