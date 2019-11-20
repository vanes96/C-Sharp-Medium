using System.Drawing;

namespace Task1._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectList objects = new ObjectList(new Point[] { new Point(5, 5), new Point(10, 10), new Point(15, 15) });

            while (true)
            {
                objects.CheckAllObjectsCollisions();
                objects.MoveAllObjectsRandomly();
                objects.MoveCursorToAllObjects();
            }
        }
    }
}
