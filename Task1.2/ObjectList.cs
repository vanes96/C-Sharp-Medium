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

        public bool CheckObjectCollision(int index)
        {
            for (int i = 0; i < _objects.Count; i++)
                if (i != index && _objects[i].X == _objects[index].X && _objects[i].Y == _objects[index].Y)
                    return true;

            return false;
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
                if (!CheckObjectCollision(i))
                {
                    Console.SetCursorPosition(_objects[i].X, _objects[i].Y);
                    Console.Write(i + 1);
                }
            }
        }
    }
}
