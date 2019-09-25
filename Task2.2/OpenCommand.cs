﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public class OpenCommand : Command
    {
        public string OwnerName { get; private set; }

        public override void Execute(ref List<Account> accounts)
        {
            if (string.IsNullOrWhiteSpace(OwnerName))
                throw new Exception("Введено некорректное имя");

            AccountId = accounts.Count + 1;
            accounts.Add(new Account(AccountId, OwnerName));
            Console.WriteLine("Операция выполнена успешно");
        }

        public OpenCommand(string ownerName)
        {
            //try
            //{
                if (string.IsNullOrWhiteSpace(ownerName))
                    throw new Exception("Введено некорректное имя!");

                OwnerName = ownerName;
                Name = "open";
                Console.WriteLine("Операция выполнена успешно");
            //}
            //catch (Exception e)
            //{
            //    Console.WriteLine("Произошла ошибка {0}", e);
            //}
        }
    }
}
