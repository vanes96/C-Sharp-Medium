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

        public virtual void OnClick(Point cursorPosition)
        {
            if (cursorPosition.X > Position.X && cursorPosition.X < Position.X + Width + 1 &&
                cursorPosition.Y >= Position.Y && cursorPosition.Y < Position.Y + Height)
                Selected = !Selected;
            else
                Selected = false;

            Draw();
        }

        public virtual void OnFocus(Point cursorPosition)
        {
            if (cursorPosition.X > Position.X && cursorPosition.X < Position.X + Width + 1 &&
                cursorPosition.Y >= Position.Y && cursorPosition.Y < Position.Y + Height)
                Focused = true;
            else
                Focused = false;

            Draw();
        }
    }
}
