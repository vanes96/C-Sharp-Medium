using System;
using System.Drawing;

namespace Task2._3
{
    public class Button : UIElement
    {
        public override void Draw()
        {
            Point previousCursorPosition = new Point(Cursor.Position.X, Cursor.Position.Y);
            int cursorY = Position.Y - 1;

            if (Focused)
                Console.ForegroundColor = ConsoleColor.DarkYellow;
            if (Selected)
                Console.ForegroundColor = ConsoleColor.DarkRed;

            Cursor.SetPosition(Position.X + 1, cursorY);
            for (int i = 0; i < Width; i++)
                Console.Write("_");

            for (int j = 0; j < Height; j++)
            {
                Cursor.SetPosition(Position.X, ++cursorY);
                Console.Write("|");
                Cursor.SetPosition(Position.X + Width + 1, cursorY);
                Console.Write("|");
            }

            Cursor.SetPosition(Position.X + 1, cursorY);
            for (int i = 0; i < Width; i++)
                Console.Write("_");

            Console.ResetColor();
            Cursor.SetPosition(previousCursorPosition.X, previousCursorPosition.Y);
        }

        public Button(int x, int y, int width, int height)
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
