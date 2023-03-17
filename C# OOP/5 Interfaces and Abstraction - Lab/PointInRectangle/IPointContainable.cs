using System;
using System.Collections.Generic;
using System.Text;

namespace PointInRectangle
{
    public interface IPointContainable
    {
        public bool Contains(Point point);
    }
}
