using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        class Object
        {
            public int X { get; private set; }
            public int Y { get; private set; }

            public void MoveRandomly()
            {
                Random random = new Random();

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

        class ObjectList
        {
            private readonly List<Object> _objects;

            public ObjectList(Point[] points)
            {
                _objects = new List<Object>();

                foreach(var point in points)
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

        static void Main(string[] args)
        {
            ObjectList objects = new ObjectList(new Point[] { new Point(5, 5), new Point(10, 10), new Point(15, 15) });

            while (true)
            {
                objects.MoveAllObjectsRandomly();
                objects.MoveCursorToAllObjects();
            }
        }

    }
}
