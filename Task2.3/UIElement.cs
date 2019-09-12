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
        public bool Selected { get; protected set; }

        // Объявляем делегат
        public delegate void ClickHandler(Point cursorPosition, Point elementPosition, int elementWidth, int elementHeight);
        // Событие, возникающее при выводе денег
        public event ClickHandler TryClick;

        public virtual void Draw(Point cursorPosition, Point elementPosition, int elementWidth, int elementHeight)
        {
            //if (cursorPosition.X >= Position.X && cursorPosition.X <= Position.X + Width &&
            //    cursorPosition.Y >= Position.Y && cursorPosition.Y <= Position.Y + Height)
            //    Selected = true;
            //else
            //    Selected = false;
            TryClick(cursorPosition, elementPosition, elementWidth, elementHeight);
        }

        public UIElement()
        {

        }
    }
}
