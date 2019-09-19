using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace Task2._3
{
    public static class Cursor
    {
        public static Point Position { get; private set; }

        public delegate void ClickHandler(Point position);
        public static event ClickHandler OnClick;
        public static event ClickHandler OnMove;

        public static void TryMove(ConsoleKeyInfo keyInfo)
        {
            switch (keyInfo.Key)
            {
                case ConsoleKey.LeftArrow:
                    Position = new Point(Position.X - 1, Position.Y);                  
                    break;
                case ConsoleKey.RightArrow:
                    Position = new Point(Position.X + 1, Position.Y);
                    break;
                case ConsoleKey.UpArrow:
                    Position = new Point(Position.X, Position.Y - 1);
                    break;
                case ConsoleKey.DownArrow:
                    Position = new Point(Position.X, Position.Y + 1);
                    break;
            }

            if (Position.X < 0)
                Position = new Point(0, Position.Y);
            if (Position.Y < 0)
                Position = new Point(Position.X, 0);

            Console.SetCursorPosition(Position.X, Position.Y);
            OnMove?.Invoke(Position);
        }

        public static void Click()
        {
            OnClick?.Invoke(Position);
        }

        static Cursor()
        {
            Position = new Point(0, 0);
        }

        public static void SetPosition(int x, int y)
        {
            Position = new Point(x, y);
            Console.SetCursorPosition(Position.X, Position.Y);
        }
    }
}
