using System;
using System.Drawing;

namespace Task2._3
{
    public abstract class UIElement
    {
        public int Width { get; protected set; }
        public int Height { get; protected set; }
        public Point Position { get; protected set; }
        public bool Selected { get; protected set; }
        public bool Focused { get; protected set; }

        public virtual void Draw()
        {

        }

        public UIElement()
        {

        }

        public void OnClick(Point cursorPosition)
        {
            if (cursorPosition.X >= Position.X && cursorPosition.X < Position.X + Width &&
                cursorPosition.Y >= Position.Y && cursorPosition.Y < Position.Y + Height)
                Selected = true;
            else
                Selected = false;
        }

        public void OnFocus(Point cursorPosition)
        {
            if (cursorPosition.X >= Position.X && cursorPosition.X < Position.X + Width &&
                cursorPosition.Y >= Position.Y && cursorPosition.Y < Position.Y + Height)
                Focused = true;
            else
                Focused = false;
        }
    }
}
