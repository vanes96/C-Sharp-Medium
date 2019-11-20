using System;
using System.Collections.Generic;

namespace Task2._3
{
    class Program
    {
        public delegate void KeyHandler(ConsoleKeyInfo keyInfo);
        public static event KeyHandler OnKeyPress;

        static void Main(string[] args)
        {
            List<UIElement> UIelements = new List<UIElement>();
            Button button = new Button(10, 1, 7, 5);
            TextField textField = new TextField(0, 7, 10, 2);
            Checkbox checkbox = new Checkbox(0, 1, 3, 3);

            UIelements.Add(button);
            UIelements.Add(textField);
            UIelements.Add(checkbox);

            foreach (var uiElement in UIelements)
                uiElement.Draw();

            while (true)
            {
                var keyInfo = ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                    Cursor.Click();
                else
                    Cursor.TryMove(keyInfo);
            }
            //Console.ReadLine();
        }

        public static ConsoleKeyInfo ReadKey()
        {
            var keyInfo = Console.ReadKey(true);

            OnKeyPress?.Invoke(keyInfo);

            return keyInfo;
        }
    }
}
