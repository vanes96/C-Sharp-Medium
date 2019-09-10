using System;
using System.Collections.Generic;
using System.Drawing;

namespace Task1._2
{
    class ObjectList
    {
        private readonly List<Object> _objects;

        public ObjectList(Point[] points)
        {
            _objects = new List<Object>();

            foreach (var point in points)
                _objects.Add(new Object(point.X, point.Y));
        }

        public void CheckAllObjectsCollisions()
        {
            int i = 0, j = 1;
            Object object1, object2;

            for (; i < _objects.Count - 1;)
            {
                object1 = _objects[i];

                for (;;)
                {
                    object2 = _objects[j];

                    if (i != j)
                    {
                        object1.CheckCollision(object2.X, object2.Y);
                        object2.CheckCollision(object1.X, object1.Y);

                        if (object2.IsAlive)
                            j++;
                        else
                            _objects.Remove(object2);      
                    }
                    else
                        j++;

                    if (j >= _objects.Count)
                    {
                        j = 1;
                        break;
                    }
                }

                if (object1.IsAlive)
                    i++;
                else
                    _objects.Remove(object1);
            }

        }

        public void MoveAllObjectsRandomly()
        {
            Random random = new Random();

            foreach (var obj in _objects)
                obj.MoveRandomly(random);        
        }

        public void MoveCursorToAllObjects()
        {
            for (int i = 0; i < _objects.Count; i++)
            {
                if (_objects[i].IsAlive)
                {
                    Console.SetCursorPosition(_objects[i].X, _objects[i].Y);
                    Console.Write(i + 1);
                }
            }
        }
    }
}
