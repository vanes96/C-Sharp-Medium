using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class OpenCommand : ICommand
    {
        public void Execute(int senderId, ref List<Account> accounts, string ownerName = null, int? receiverId = null, int? amount = null)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ownerName))
                    throw new ArgumentException(ownerName);

                accounts.Add(new Account(accounts.Count + 1, ownerName));
                Console.WriteLine("Операция выполнена успешно");
                //return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка {0}", e);
                //return false;
            }
        }
    }
}
