using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Bank
    {
        public List<Account> Accounts { get; private set; }
        //public List<Command> History { get; private set; }

        public bool OpenAccount(string ownerName)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ownerName))
                    throw new ArgumentException(ownerName);

                Accounts.Add(new Account(Accounts.Count + 1, ownerName));
                Console.WriteLine("Операция выполнена успешно");
                return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка {0}", e);
                return false;
            }
        }

        public void CloseAccout(int id)
        {
            if (Accounts.RemoveAll(a => a.Id == id) > 0)
                Console.WriteLine("Операция выполнена успешно");
            else
                Console.WriteLine("Счета с таким Id не существует");
        }

        public void UndoCommand()
        {

        }

        public Account GetLastAccount()
        {
            return Accounts[Accounts.Count - 1];
        }

        public Bank()
        {
            Accounts = new List<Account>();
        }
    }
}
