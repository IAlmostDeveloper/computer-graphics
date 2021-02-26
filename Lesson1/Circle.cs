using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson1
{
    
    class Circle
    {
        public int Radius { get; private set; }
        public Point Center { get; private set; }
        public Color Color { get; set; }


        public Circle(Point center, int radius, Color color)
        {
            Center = center;
            Radius = radius;
            Color = color;
        }

        public Circle(Point center, int radius) : this(center, radius, Color.Black)
        {

        }

    }
}
