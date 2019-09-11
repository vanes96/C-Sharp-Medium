using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class CloseCommand : Command
    {
        public override void Execute(ref List<Account> accounts)
        {
            if (accounts.RemoveAll(a => a.Id == AccountId) > 0)
                Console.WriteLine("Операция выполнена успешно");
            else
                Console.WriteLine("Счета с таким Id не существует");
        }

        public CloseCommand(int accountId)
        {
            AccountId = accountId;
            Name = "close";
        }
    }
}
