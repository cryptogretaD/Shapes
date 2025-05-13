using System;
using System.Drawing;
using System.Text;

namespace MyPaint.Models
{
    [Serializable]
    public class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height)
        {
            Position = new Point(x, y);
            Width = width;
            Height = height;

            Area = (double)Height / 10 * ((double)Width / 10);
            Perimeter = ((double)Height + Width) / 10 * 2;
        }
        
        public override string ShowResult()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A = w * h");
            sb.AppendLine($"A = {Width} * {Height}");
            sb.AppendLine($"A = {Area:F2}");

            sb.AppendLine("P = 2 * w + 2 * h");
            sb.AppendLine($"P =  2 * {Width} + 2 * {Height}");
            sb.AppendLine($"P = {Perimeter:F2}");

            return sb.ToString();
        }

        public override void Draw(Graphics graphics)
        {
            var shapeToDraw = new System.Drawing.Rectangle(
                Position.X,
                Position.Y,
                Width,
                Height);

            if (IsFilled)
            {
                graphics.FillRectangle(FillBrush, shapeToDraw);
            }

            graphics.DrawRectangle(Border, shapeToDraw);
        }

        public override string ToString()
        {
            return $"Rectangle@{Height}x{Width}";
        }
    }
}
