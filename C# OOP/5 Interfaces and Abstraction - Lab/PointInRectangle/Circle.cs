using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Circle
    {
        public Circle(int x, int y, int radius)
        {
            Center = new Point(x, y);
            Radius = radius;
        }

        public Point Center { get; set; }
        public int Radius { get; set; }

        public bool Contains(Point point)
        {
            var distance = Math.Sqrt((point.X - Center.X) * (point.X - Center.X)
                + (point.Y - Center.Y) * (point.Y - Center.Y));

            if(distance <= Radius)
            {
                return true;
            }
            return false;
        }
    }
}
