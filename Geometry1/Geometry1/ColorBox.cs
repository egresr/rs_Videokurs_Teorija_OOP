using System;
using System.Drawing;

namespace Geometry1
{
    class ColorBox : Box
    {
        public Pen pen;

        public ColorBox(int positionX1, int positionY1, int positionX2, int positionY2, Color color)
    : this(new Pixel(positionX1, positionY1), new Pixel(positionX2, positionY2), color)
        {
        }

        public ColorBox(Pixel obenLinks, Pixel untenRechts, Color color)
            :base (obenLinks, untenRechts)
        {
            pen = new Pen(color);
        }
    }
}
