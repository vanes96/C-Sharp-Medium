using System;
using System.Drawing;

namespace Task2._3
{
    public class TextField : UIElement
    {
        private string _text;

        private void DrawText(Point previousCursorPosition)
        {
            int maxTextWidth = Width, textLength = _text.Length;
            int countRows = (textLength - 1) / maxTextWidth + 1;

            Cursor.SetPosition(Position.X + 1, Position.Y);

            for (int i = 0; i < countRows; i++)
            {
                Console.Write(_text.Substring(maxTextWidth * i, i == countRows - 1 ? maxTextWidth - (countRows * maxTextWidth - textLength) : maxTextWidth));
                if (countRows - i > 1)
                    Cursor.SetPosition(Position.X + 1, Position.Y + countRows - 1);
            }

            if (!Selected)
                Cursor.SetPosition(previousCursorPosition.X, previousCursorPosition.Y);
        }

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

            for (int i = 0; i < Height; i++)
            {
                Cursor.SetPosition(Position.X, ++cursorY);
                string emptyString = "|";
                for (int j = 0; j < Width; j++)
                    emptyString += " ";
                emptyString += "|";
                Console.Write(emptyString);
            }

            Cursor.SetPosition(Position.X, ++cursorY);
            for (int i = 0; i < Width + 2; i++)
                Console.Write("'");

            Console.ResetColor();

            DrawText(previousCursorPosition);
        }

        public void OnWrite(ConsoleKeyInfo keyInfo)
        {
            char symbol = keyInfo.KeyChar;

            if (Selected)
            {
                if (keyInfo.Key == ConsoleKey.Backspace && _text.Length > 0)
                    _text = _text.Remove(_text.Length - 1);
                else
                if (char.IsLetterOrDigit(symbol) && _text.Length < Width * Height)
                    _text += symbol;
            }
        }

        public TextField(int x, int y, int width, int height)
        {
            Selected = false;
            Position = new Point(x, y);
            Width = width;
            Height = height;
            _text = "";

            Cursor.OnClick += OnClick;
            Cursor.OnMove += OnFocus;
            Program.OnKeyPress += OnWrite;
        }
    }
}
