using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class OpenCommand : Command
    {
        public string OwnerName { get; private set; }
        public int StartBalance { get; private set; }

        public override void Execute(ref List<Account> accounts)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(OwnerName))
                    throw new ArgumentException(OwnerName);

                AccountId = accounts.Count + 1;
                accounts.Add(new Account(AccountId, OwnerName, StartBalance));
                Console.WriteLine("Операция выполнена успешно");
                //return true;
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка {0}", e);
                //return false;
            }
        }

        public OpenCommand(string ownerName, int amount)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(ownerName) || amount <= 0)
                    throw new ArgumentException(ownerName + amount);

                OwnerName = ownerName;
                StartBalance = amount;
                Name = "open";
                //Console.WriteLine("Операция выполнена успешно");
            }
            catch (Exception e)
            {
                Console.WriteLine("Произошла ошибка {0}", e);
            }
        }
    }
}
