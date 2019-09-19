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
            Button button = new Button(5, 5, 15, 4);
            TextField textField = new TextField(2, 2, 10, 2);
            Checkbox checkbox = new Checkbox(6, 6, 1, 1);

            //UIelements.Add(button);
            UIelements.Add(textField);
            UIelements.Add(checkbox);

            while(true)
            {
                var keyInfo = ReadKey();

                if (keyInfo.Key == ConsoleKey.Enter)
                    Cursor.Click();
                else
                    Cursor.TryMove(keyInfo);

                foreach(var uiElement in UIelements)
                {
                    uiElement.Draw();
                }             
            }     
        }

        public static ConsoleKeyInfo ReadKey()
        {
            var keyInfo = Console.ReadKey(true);

            OnKeyPress?.Invoke(keyInfo);

            return keyInfo;
        }
    }
}
