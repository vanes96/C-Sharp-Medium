using System;
using System.Collections.Generic;
using System.Drawing;

namespace Task2
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

        public bool IsObjectAlive(int index)
        {
            for (int i = 0; i < _objects.Count; i++)
                if (i != index && _objects[i].X == _objects[index].X && _objects[i].Y == _objects[index].Y)
                    return false;

            return true;
        }

        public void MoveAllObjectsRandomly()
        {
            foreach (var obj in _objects)
                obj.MoveRandomly();
        }

        public void MoveCursorToAllObjects()
        {
            for (int i = 0; i < _objects.Count; i++)
                if (IsObjectAlive(i))
                {
                    Console.SetCursorPosition(_objects[i].X, _objects[i].Y);
                    Console.Write(i + 1);
                }
        }
    }
}
