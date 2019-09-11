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

        public Account(int id, string ownerName, int balance)
        {
            Id = id;
            Balance = balance;
            OwnerName = ownerName;
        }

        public bool GetMoney(int amount)
        {
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException(amount.ToString());

                if (Balance >= amount)
                {
                    Balance -= amount;
                    return true;
                }
                else
                {
                    Console.WriteLine("На счете недостаточно средств");
                    return false;
                }
            }
            catch(Exception e)
            {
                Console.WriteLine("Произошла ошибка {0}", e);
                return false;
            }
        }

        public bool PutMoney(int amount)
        {
            try
            {
                if (amount <= 0)
                    throw new ArgumentOutOfRangeException(amount.ToString());

                Balance += amount;
                Console.WriteLine("Операция выполнена успешно");
                return true;
            }
            catch(Exception e)
            {
                Console.WriteLine("Произошла ошибка {0}", e);
                return false;
            }
        }
    }
}
