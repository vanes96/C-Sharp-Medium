using System;

namespace Task1._2
{
    class Object
    {
        public int X { get; private set; }

        public int Y { get; private set; }

        public void MoveRandomly(Random random)
        {          
            X += random.Next(-1, 1);
            if (X < 0)
                X = 0;

            Y += random.Next(-1, 1);
            if (Y < 0)
                Y = 0;
        }

        public Object(int x, int y)
        {
            X = x;
            Y = y;
        }
    }
}
