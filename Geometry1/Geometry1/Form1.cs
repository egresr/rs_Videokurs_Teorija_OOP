using System;
using System.Drawing;
using System.Windows.Forms;

namespace Geometry1
{
    public struct Pixel
    {
        public int x, y;

        public Pixel(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int GetDistance(Pixel pixelX)
        {
            return Convert.ToInt32
                (
                    Math.Sqrt
                    (
                        (x - pixelX.x) * (x - pixelX.x) +
                        (y - pixelX.y) * (y - pixelX.y)
                    )
                );
        }
    }
    public partial class Form1 : Form
    {
        Bitmap bmp;
        Pen pen;
        Graphics graph;

        Shape[] snowman1;

        Pixel A, B, C, D, E, F, G, H, I, J, K, L, M, N, O;

        // Snowman1
        Circle circle1;
        Circle circle2;
        Circle circle3;

        Line line1;
        Line line2;

        Box box1;
        Box box2;

        // Snowman2
        ColorCircle circle21;
        ColorCircle circle22;
        ColorCircle circle23;

        ColorLine line21;
        ColorLine line22;

        ColorBox box21;
        ColorBox box22;

        public Form1()
        {
            InitializeComponent();

            Init();
            InitSnowman1();
            InitSnowman2();
            Draw();
        }

        private void Init()
        {
            bmp = new Bitmap(picture.Width, picture.Height);
            pen = new Pen(Color.Blue, 4);
            graph = Graphics.FromImage(bmp);
        }
        private void InitSnowman1()
        {
            snowman1 = new Shape[7];

            A = new Pixel(200, 80);
            B = new Pixel(210, 180);
            C = new Pixel(220, 360);
            D = new Pixel(200, 110);
            E = new Pixel(200, 255);
            F = new Pixel(158, 129);
            G = new Pixel(64, 200);
            H = new Pixel(265, 131);
            I = new Pixel(366, 200);
            J = new Pixel(120, 450);
            K = new Pixel(170, 470);
            L = new Pixel(270, 450);
            M = new Pixel(320, 470);

            snowman1[0] = new Circle(A, D);
            snowman1[1] = new Circle(B, D);
            snowman1[2] = new Circle(C, E);

            snowman1[3] = new Line(F, G);
            snowman1[4] = new Line(H, I);

            snowman1[5] = new Box(J, K);
            snowman1[6] = new Box(L, M);

        }
        private void InitSnowman2()
        {
            int delta = 310;

            A = new Pixel(delta + 200, 80);
            B = new Pixel(delta + 210, 180);
            C = new Pixel(delta + 220, 360);
            D = new Pixel(delta + 200, 110);
            E = new Pixel(delta + 200, 255);
            F = new Pixel(delta + 158, 129);
            G = new Pixel(delta + 64, 200);
            H = new Pixel(delta + 265, 131);
            I = new Pixel(delta + 366, 200);
            J = new Pixel(delta + 120, 450);
            K = new Pixel(delta + 170, 470);
            L = new Pixel(delta + 270, 450);
            M = new Pixel(delta + 320, 470);

            circle21 = new ColorCircle(A, D, Color.DarkRed);
            circle22 = new ColorCircle(B, D, Color.DarkOrange);
            circle23 = new ColorCircle(C, E, Color.DarkGreen);

            line21 = new ColorLine(F, G, Color.OrangeRed);
            line22 = new ColorLine(H, I, Color.Orange);

            box21 = new ColorBox(J, K, Color.Pink);
            box22 = new ColorBox(L, M, Color.BlueViolet);

        }


        private void Draw(Shape shape)
        {
            Draw(shape);


        }
        private void Draw()
        {
            Draw(shape);
            //Snowman
            //Draw(line1);
            //Draw(line2);

            //Draw(box1);
            //Draw(box2);

            //Draw(circle1);
            //Draw(circle2);
            //Draw(circle3);

            //Snowman2
            Draw(line21);
            Draw(line22);

            Draw(box21);
            Draw(box22);

            Draw(circle21);
            Draw(circle22);
            Draw(circle23);

            picture.Image = bmp;
        }
        private void Draw(Line line)
        {
            graph.DrawLine(
                pen,
                line.begin.x,
                line.begin.y,
                line.end.x,
                line.end.y
                );
        }
        private void Draw(ColorLine line)
        {
            graph.DrawLine(
                line.pen,
                line.begin.x,
                line.begin.y,
                line.end.x,
                line.end.y
                );
        }
        private void Draw(Box box)
        {
            graph.DrawRectangle(
                pen,
                box.obenLinks.x,
                box.obenLinks.y,
                box.width,
                box.height
                );
        }
        private void Draw(ColorBox box)
        {
            graph.DrawRectangle(
                box.pen,
                box.obenLinks.x,
                box.obenLinks.y,
                box.width,
                box.height
                );
        }
        private void Draw(Circle circle)
        {
            graph.DrawEllipse(
                pen,
                circle.eckeLinksOben.x,
                circle.eckeLinksOben.y,
                circle.rectangleWidth,
                circle.rectangleHeight
                );
        }
        private void Draw(ColorCircle circle)
        {
            graph.DrawEllipse(
                circle.pen,
                circle.eckeLinksOben.x,
                circle.eckeLinksOben.y,
                circle.rectangleWidth,
                circle.rectangleHeight
                );
        }

    }
}
