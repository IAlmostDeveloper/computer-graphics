using System.Drawing;

namespace Lesson1
{
    class Canvas
    {
        public Graphics Graphics { get; private set; }
        public Color BackgroundColor { get; set; }
        public bool IsEnabled { get; private set; }

        public Canvas(Graphics graphics, Color backgroundColor)
        {
            Graphics = graphics;
            BackgroundColor = backgroundColor;
            IsEnabled = false;
        }

        public Canvas(Graphics graphics) : this(graphics, Color.LightGray) { }

        public void DrawLine(Line line)
        {
            Graphics.DrawLine(line);
        }

        public void DrawCircle(Circle circle)
        {
            Graphics.DrawCircle(circle);
        }

        public void DrawPolygon(Polygon polygon)
        {
            Graphics.DrawPolygon(polygon);
        }

        public void Clear()
        {
            Graphics.Clear(BackgroundColor);
        }

        public void Toggle()
        {
            IsEnabled = !IsEnabled;
        }
    }
}
