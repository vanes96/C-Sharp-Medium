using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    public interface ICommand
    {
        void Execute(int senderId, ref List<Account> accounts, string ownerName = null, int? receiverId = null, int? amount = null);
    }

    public enum CommandType { Open, Close, Transfer, Undo}
}
