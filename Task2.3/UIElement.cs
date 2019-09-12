using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task2._3
{
    public abstract class UIElement
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public Point Position { get; protected set; }

        public virtual void Draw()
        {

        }

        public UIElement()
        {

        }
    }
}
