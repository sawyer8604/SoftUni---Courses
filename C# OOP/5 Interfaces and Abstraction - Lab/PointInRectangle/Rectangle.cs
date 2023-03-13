using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public class Rectangle
    {
        public Rectangle(int top, int left, int bottom, int right)
        {
            TopLeftCoordinates = new Point(left, top);
            BottomRightCoordinates = new Point(right, bottom);
        }
        public Rectangle(Point topLeft, Point bottomRight)
        {
            TopLeftCoordinates = topLeft;
            BottomRightCoordinates = bottomRight;
        }

        public Point TopLeftCoordinates { get; private set; }
        public Point BottomRightCoordinates { get; private set; }

        public bool Contains(Point point)
        {
            if(point.X >= TopLeftCoordinates.X
                && point.X <= BottomRightCoordinates.X
                && point.Y >= BottomRightCoordinates.Y
                && point.Y <= TopLeftCoordinates.Y)
            {
                return true;
            }

            return false;
        }
    }
}
