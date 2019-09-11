using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public abstract class Command
    {
        protected int _accountId;
        public virtual void Execute(ref List<Account> accounts)
        {

        }
    }

    public enum CommandType { Open, Close, Transfer, Undo}
}
