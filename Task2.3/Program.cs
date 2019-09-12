using System;
using System.Collections.Generic;
using System.Drawing;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UIElement> UIelements = new List<UIElement>();
            Point cursorPosition = new Point(0, 0);

            Button button = new Button(10, 15, 15, 4);       
            UIelements.Add(button);
            button.TryClick += TryClick;
            //button.TryClick += new Button.ClickHandler(TryClick);


            Console.SetCursorPosition(cursorPosition.X, cursorPosition.Y);

            while(true)
            {
                ConsoleKey pressedKey = Console.ReadKey().Key;

                switch(pressedKey)
                {
                    case ConsoleKey.LeftArrow:
                        cursorPosition.X--;
                        break;
                    case ConsoleKey.RightArrow:
                        cursorPosition.X++;
                        break;
                    case ConsoleKey.UpArrow:
                        cursorPosition.Y--;
                        break;
                    case ConsoleKey.DownArrow:
                        cursorPosition.Y++;
                        break;
                }

                foreach(var uiElement in UIelements)
                {
                    //uiElement.TryClick_(cursorPosition);
                    uiElement.Draw(cursorPosition, uiElement.Position, uiElement.Width, uiElement.Height);
                }

                Console.SetCursorPosition(cursorPosition.X, cursorPosition.Y);

                if (Console.ReadKey().Key == ConsoleKey.Enter)
                {

                }
            }

            
        }

        private static void TryClick(Point clickPosition, Point elementPosition, int width, int height)
        {
            if (clickPosition.X >= elementPosition.X && clickPosition.X <= elementPosition.X + width &&
                clickPosition.Y >= elementPosition.Y && clickPosition.Y <= elementPosition.Y + height)
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else
            {
                Console.ResetColor();
            }
        }
    }
}
