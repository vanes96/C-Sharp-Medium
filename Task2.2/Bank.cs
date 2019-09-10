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

        public void OpenAccount(string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
                throw new ArgumentException(ownerName);

            Accounts.Add(new Account(Accounts.Count + 1, ownerName));
        }

        public void CloseAccout(int id)
        {
            Accounts.RemoveAll(a => a.Id == id);
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
