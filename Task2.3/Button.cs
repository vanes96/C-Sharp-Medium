using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task2._3
{
    public class Button : UIElement
    {
        public override void Draw(Point cursorPosition, Point elementPosition, int elementWidth, int elementHeight)
        {
            base.Draw(cursorPosition, elementPosition, elementWidth, elementHeight);

            if (Selected)
                Console.ForegroundColor = ConsoleColor.Red;

            int cursorY = Position.Y;
            Console.SetCursorPosition(Position.X, cursorY);

            for (int i = 0; i < Width; i++)
                Console.Write("-");
            Console.SetCursorPosition(Position.X, ++cursorY);

            for (int j = 0; j < Height; j++)
            {
                Console.Write("|");
                for (int i = 0; i < Width - 2; i++)
                    Console.Write(" ");
                Console.Write("|");
                Console.SetCursorPosition(Position.X, ++cursorY);
            }

            for (int i = 0; i < Width; i++)
                Console.Write("-");

            Console.ResetColor();
        }

        public Button(int x, int y, int width, int height)
        {
            Selected = false;
            Position = new Point(x, y);
            Width = width;
            Height = height;
        }
    }
}
