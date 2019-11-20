using System;

namespace Task1._2
{
    class Object
    {
        public int X { get; private set; }
        public int Y { get; private set; }
        public bool IsAlive { get; private set; }

        public void CheckCollision(int x, int y)
        {
            if (X == x && Y == y)
                IsAlive = false;
        }

        public void MoveRandomly(Random random)
        {
            if (IsAlive)
            {
                X += random.Next(-1, 1);
                if (X < 0)
                    X = 0;

                Y += random.Next(-1, 1);
                if (Y < 0)
                    Y = 0;
            }
        }

        public Object(int x, int y)
        {
            X = x;
            Y = y;
            IsAlive = true;
        }
    }
}
