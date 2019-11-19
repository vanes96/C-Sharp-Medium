using System;
using System.Collections.Generic;

namespace Task2._2
{
    public class CloseCommand : Command
    {
        public override void Do(ref List<Account> accounts)
        {
            if (accounts.RemoveAll(a => a.Id == AccountId) <= 0)
                throw new Exception("Счета с таким Id не существует");
        }

        public CloseCommand(int accountId)
        {
            AccountId = accountId;
            Name = "close";
        }
    }
}
