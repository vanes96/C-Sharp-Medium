using System;

namespace Task2._2
{
    public class Account
    {
        public int Id { get; }
        public string OwnerName { get; }
        public int Balance { get; private set; }

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
                Balance -= amount;
            else
                throw new Exception("Account does not have enough money");
        }

        public void PutMoney(int amount)
        {
            if (amount <= 0)
                throw new ArgumentOutOfRangeException(amount.ToString());

            Balance += amount;
        }
    }
}
