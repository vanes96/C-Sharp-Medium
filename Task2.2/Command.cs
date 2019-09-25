using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public abstract class Command
    {
        public string Name { get; protected set; }
        public int AccountId { get; protected set; }

        public virtual void Execute(ref List<Account> accounts)
        {
            //return true;
        }
    }

    public enum CommandType { Open, Close, Transfer, Undo}
}
