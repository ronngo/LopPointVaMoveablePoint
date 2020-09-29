using System;

namespace LopPointVaMoveablePoint
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Point");
            Point point = new Point(5.6f, 7.9f);


            Console.WriteLine(point);
            Console.WriteLine("MovablePoint");
            MovablePoint movablePoint = new MovablePoint(8.2f, 20.6f);
            Console.WriteLine(movablePoint.Move());
            Console.WriteLine(movablePoint.ToString());
        }
    }
}