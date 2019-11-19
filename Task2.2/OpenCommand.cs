using System;
using System.Collections.Generic;

namespace Task2._2
{
    public class OpenCommand : Command
    {
        public string OwnerName { get; private set; }

        public override void Do()
        {
            if (string.IsNullOrWhiteSpace(OwnerName))
                throw new Exception("Введено некорректное имя");

            //Bank.Accounts
        }

        public OpenCommand(string ownerName)
        {
            if (string.IsNullOrWhiteSpace(ownerName))
                throw new Exception("Введено некорректное имя!");

            OwnerName = ownerName;
            Name = "open";
        }
    }
}
