namespace Geometry1
{
    class Circle : Shape
    {
        public Pixel center;
        public int radius;
        public Pixel eckeLinksOben;
        public int rectangleHeight, rectangleWidth;

        public Circle(int x, int y, int radius)
            :this(new Pixel(x, y), radius)
        {
        }

        public Circle(Pixel center, Pixel radius)
            :this(center, center.GetDistance(radius))
        {
        }

        public Circle(Pixel center, int radius)
        {
            this.center = center;
            this.radius = radius;

            BestimmeQuadratInkreis();
        }
        


        private void BestimmeQuadratInkreis()
        {
            eckeLinksOben.x = center.x - radius;
            eckeLinksOben.y = center.y - radius;

            rectangleHeight = rectangleWidth= radius * 2;
        }
    }
}
