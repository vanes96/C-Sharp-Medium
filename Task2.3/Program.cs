using System;
using System.Collections.Generic;

namespace Task2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<UIElement> UIelements = new List<UIElement>();

            Button button = new Button(15, 5, 7, 2);
            button.Draw();
        }
    }
}
