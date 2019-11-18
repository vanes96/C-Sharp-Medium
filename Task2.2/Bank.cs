using System;
using System.Collections.Generic;

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
