using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    class Polygon
    {
        public readonly IEnumerable<Point> points;
        public Color Color { get; private set; }

        public int Width { get; private set; }

        public Polygon(Color color, IEnumerable<Point> points, int width)
        {
            Color = color;
            this.points = points;
            Width = width;
        }
    }
}
