using System.Drawing;

namespace Geometry1
{
    class ColorCircle : Circle
    {
        public Pen pen;


        public ColorCircle(int x, int y, int radius, Color color)
            :this(new Pixel(x, y), radius, color)
        {
        }

        public ColorCircle(Pixel center, Pixel radius, Color color)
            :this(center, center.GetDistance(radius), color)
        {
        }

        public ColorCircle(Pixel center, int radius, Color color)
            :base(center, radius)
        {
            pen = new Pen(color);
        }
    }
}
