using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class Account
    {
        public int Balance { get; private set; }
        public int Id { get; }
        public string OwnerName { get; }

        public Account(int id, string ownerName)
        {
            Id = id;
            Balance = 0;
            OwnerName = ownerName;
        }

        public void TakeMoney(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(amount.ToString());

            if (Balance >= amount)
            {
                Balance -= amount;
                //return true;
            }
            else
            {
                throw new Exception("На счете недостаточно средств");
                //return false;
            }
        }

        public void PutMoney(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(amount.ToString());

            Balance += amount;
            //return true;
        }
    }
}
