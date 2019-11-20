using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task2._3
{
    public class Checkbox : UIElement
    {
        private bool _checked;

        public override void Draw()
        {
            Point previousCursorPosition = new Point(Cursor.Position.X, Cursor.Position.Y);
            int cursorY = Position.Y - 1;

            if (Focused)
                Console.ForegroundColor = ConsoleColor.Cyan;
            if (Selected)
                Console.ForegroundColor = ConsoleColor.DarkBlue;

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

            Cursor.SetPosition(Position.X, ++cursorY);
            for (int i = 0; i < Width + 2; i++)
                Console.Write("'");

            Console.ResetColor();

            for (int i = 0; i < Height; i++)
            {
                Cursor.SetPosition(Position.X + 1, Position.Y + i);
                for (int j = 0; j < Width; j++)
                    Console.Write(_checked?"#":" ");
            }

            Cursor.SetPosition(previousCursorPosition.X, previousCursorPosition.Y);
        }

        public override void OnClick(Point cursorPosition)
        {
            if (cursorPosition.X > Position.X && cursorPosition.X < Position.X + Width + 1 &&
                cursorPosition.Y >= Position.Y && cursorPosition.Y < Position.Y + Height)
            {
                Selected = !Selected;
                _checked = !_checked;
            }
            else
                Selected = false;

            Draw();
        }

        public Checkbox(int x, int y, int width, int height)
        {
            _checked = false;
            Selected = false;
            Position = new Point(x, y);
            Width = width;
            Height = height;

            Cursor.OnClick += OnClick;
            Cursor.OnMove += OnFocus;
        }
    }
}
