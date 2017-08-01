using System;

namespace Geometry1
{
    class Box : Shape
    {
        public Pixel obenLinks;
        public Pixel untenRechts;
        public int width, height;


        public Box(Pixel obenLinks, Pixel untenRechts)
        {
            this.obenLinks = obenLinks;
            this.untenRechts = untenRechts;
            width = Math.Abs(untenRechts.x - obenLinks.x);
            height = Math.Abs(untenRechts.y - obenLinks.y);
        }

        public Box(int positionX1, int positionY1, int positionX2, int positionY2)
            : this(new Pixel(positionX1, positionY1), new Pixel(positionX2, positionY2))
        {
        }
    }
}
