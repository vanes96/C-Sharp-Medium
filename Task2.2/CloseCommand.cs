using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class CloseCommand : ICommand
    {
        public void Execute(int senderId, ref List<Account> accounts, string ownerName = null, int? receiverId = null, int? amount = null)
        {
            if (accounts.RemoveAll(a => a.Id == senderId) > 0)
                Console.WriteLine("Операция выполнена успешно");
            else
                Console.WriteLine("Счета с таким Id не существует");
        }
    }
}
