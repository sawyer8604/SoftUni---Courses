using System;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangle rectangle = new Rectangle(3, 1, 1, 3);

            Console.WriteLine(rectangle.Contains(new Point(2, 2))); // True
            Console.WriteLine(rectangle.Contains(new Point(3, 1))); // True
            Console.WriteLine(rectangle.Contains(new Point(3, 4))); // False

            Circle circle = new Circle(0, 0, 2);

            Console.WriteLine(circle.Contains(new Point(0, 0))); // True
            Console.WriteLine(circle.Contains(new Point(0, 2))); // True
            Console.WriteLine(circle.Contains(new Point(2, 0))); // True
            Console.WriteLine(circle.Contains(new Point(0, 3))); // False

        }
    }
}
