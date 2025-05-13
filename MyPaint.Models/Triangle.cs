using System;
using System.Drawing;
using System.Text;
using static System.Math;

namespace MyPaint.Models
{
    [Serializable]
    public class Triangle : Shape
    {
        public Triangle(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            Position = new Point(
                Min(x1, Min(x2, x3)), 
                Min(y1, Min(y2, y3)));

            int maxX = Max(x1, Max(x2, x3));
            int maxY = Max(y1, Max(y2, y3));

            int minX = Min(x1, Min(x2, x3));
            int minY = Min(y1, Min(y2, y3));

            Width = maxX - minX;
            Height = maxY - minY;

            Area = CalculateArea(x1, y1, x2, y2, x3, y3);
            Perimeter = CalculatePerimeter(x1, y1, x2, y2, x3, y3);
        }

        protected double CalculateArea(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            return Abs((x1 * (y2 - y3) + x2 * (y3 - y1) + x3 * (y1 - y2)) / 2.0);
        }

        protected double CalculatePerimeter(int x1, int y1, int x2, int y2, int x3, int y3)
        {
            double side1 = Sqrt(Pow(x2 - x1, 2) + Pow(y2 - y1, 2));
            double side2 = Sqrt(Pow(x3 - x2, 2) + Pow(y3 - y2, 2));
            double side3 = Sqrt(Pow(x1 - x3, 2) + Pow(y1 - y3, 2));

            return side1 + side2 + side3;
        }

        public override string ShowResult()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A = (1/2) * b * h");
            sb.AppendLine($"A = (1/2) * {Width} * {Height}");
            sb.AppendLine($"A = {Area:F2}");

            sb.AppendLine("P = a + b + c");
            sb.AppendLine($"P = {Width} + {Height} + {Width}");
            sb.AppendLine($"P = {Perimeter:F2}");

            return sb.ToString();
        }

        public override void Draw(Graphics graphics)
        {
            Point vertex1 = new Point(Position.X, Position.Y + Height);
            Point vertex2 = new Point(Position.X + Width, Position.Y + Height);
            Point vertex3 = new Point(Position.X + (Width / 2), Position.Y);

            Point[] trianglePoints = { vertex1, vertex2, vertex3 };

            if (IsFilled)
            {
                graphics.FillPolygon(FillBrush, trianglePoints);
            }

            graphics.DrawPolygon(Border, trianglePoints);
        }

        public override string ToString()
        {
            return $"Triangle@{Width}x{Height}";
        }
    }
}
