using System.Drawing;
using System.Linq;

namespace Lesson1
{
    static class Extensions
    {
        public static void DrawLine(this Graphics graphics, Line line)
        {
            var pen = new Pen(new SolidBrush(line.Color), line.Width);
            graphics.DrawLine(pen, line.Point1, line.Point2);
        }

        public static void DrawCircle(this Graphics graphics, Circle circle)
        {
            var pen = new Pen(new SolidBrush(circle.Color), circle.Radius*2);
            var diameter = circle.Radius * 2;
            graphics.DrawEllipse(pen, circle.Center.X - circle.Radius, 
                circle.Center.Y - circle.Radius, diameter, diameter);
        }

        public static void DrawPolygon(this Graphics graphics, Polygon polygon)
        {
            var pen = new Pen(new SolidBrush(polygon.Color), polygon.Width);
            graphics.DrawPolygon(pen, polygon.points.ToArray());
        }
    }
}
