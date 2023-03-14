using System;
using System.Collections.Generic;

namespace PointInRectangle
{
    class Program
    {
        static void Main(string[] args)
        {
            var figures = new List<IPointContainable>();

            figures.Add(new Rectangle(3, 1, 1, 3));
            figures.Add(new Circle(0, 0, 2));

            foreach (var figure in figures)
            {
                Console.WriteLine(figure.Contains(new Point(2, 2))); 
                Console.WriteLine(figure.Contains(new Point(3, 1))); 
                Console.WriteLine(figure.Contains(new Point(3, 4)));               
                Console.WriteLine(figure.Contains(new Point(0, 0))); 
                Console.WriteLine(figure.Contains(new Point(0, 2))); 
                Console.WriteLine(figure.Contains(new Point(2, 0))); 
                Console.WriteLine(figure.Contains(new Point(0, 3)));
                Console.WriteLine();

            }

        }
    }
}
