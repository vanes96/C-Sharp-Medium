using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task2._3
{
    public class Checkbox : UIElement
    {
        public override void Draw()
        {
            Point previousCursorPosition = new Point(Cursor.Position.X, Cursor.Position.Y);
            int cursorY = Position.Y - 1;
            int maxTextWidth = Width;

            Cursor.SetPosition(Position.X + 1, cursorY);

            if (Focused)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (Selected)
                Console.ForegroundColor = ConsoleColor.DarkRed;

            for (int i = 0; i < maxTextWidth; i++)
                Console.Write("_");

            for (int i = 0; i < Height; i++)
            {
                Cursor.SetPosition(Position.X, ++cursorY);
                string emptyString = "|";
                for (int j = 0; j < maxTextWidth; j++)
                    emptyString += " ";
                emptyString += "|";
                Console.Write(emptyString);
            }

            Cursor.SetPosition(Position.X + 1, cursorY);
            for (int i = 0; i < maxTextWidth; i++)
                Console.Write("_");

            Console.ResetColor();

            if (Selected)
            {
                for (int i = 0; i < Height; i++)
                {
                    Cursor.SetPosition(Position.X + 1, Position.Y + i);
                    for (int j = 0; j < maxTextWidth; j++)
                        Console.Write("*");
                }
            }
            Cursor.SetPosition(previousCursorPosition.X, previousCursorPosition.Y);
        }

        public Checkbox(int x, int y, int width, int height)
        {
            Selected = false;
            Position = new Point(x, y);
            Width = width;
            Height = height;

            Cursor.OnClick += OnClick;
            Cursor.OnMove += OnFocus;
        }
    }
}
