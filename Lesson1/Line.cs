using System.Drawing;

namespace Lesson1
{
    class Line
    {
        public Point Point1 { get; set; }
        public Point Point2 { get; set; }
        public int Width { get; set; }
        public Color Color { get; set; }
        public Line(Point point1, Point point2, int width, Color color)
        {
            Point1 = point1;
            Point2 = point2;
            Width = width;
            Color = color;
        }

        public Line(Point point1, Point point2, int width) : this(point1, point2, width, Color.Black) { }
    }
}
