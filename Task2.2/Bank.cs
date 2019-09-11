using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2._2
{
    class Bank
    {
        public List<Command> Commands { get; private set; }

        public void AddCommand(Command command)
        {
            Commands.Add(command);
        }

    }
}
