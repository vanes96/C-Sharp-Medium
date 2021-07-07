using System;
using System.Collections.Generic;

namespace Task2._2
{
    public abstract class Command
    {
        public string Name { get; protected set; }
        public int AccountId { get; protected set; }   

        public virtual void Do()
        { }

        public virtual void Undo()
        { }
    }
}
