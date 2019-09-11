using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class TransferCommand : ICommand
    {
        public void Execute(int senderId, ref List<Account> accounts, string ownerName = null, int? receiverId = null, int? amount = null)
        {
            if (accounts.Single(a => a.Id == senderId).GetMoney(amount.Value))
            {
                accounts.Single(a => a.Id == receiverId).PutMoney(amount.Value);
                Console.WriteLine("Операция выполнена успешно");
            }
            else
                Console.WriteLine("Невозможно осуществить перевод средств");
        }
    }
}
