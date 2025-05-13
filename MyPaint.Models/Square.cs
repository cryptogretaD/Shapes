using System;
using System.Drawing;
using System.Text;

namespace MyPaint.Models
{
    [Serializable]
    public class Square : Shape
    {
        public Square(int x, int y, int side)
        {
            Position = new Point(x, y);
            Height = Width = side;

            Area = Math.Pow((double)Height / 10, 2);
            Perimeter = (double)Height / 10 * 4;
        }

        public override string ShowResult()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A =  a ^ 2");
            sb.AppendLine($"A = {Height} ^ 2");
            sb.AppendLine($"A = {Area:F2}");

            sb.AppendLine("P = 4 * a");
            sb.AppendLine($"P = 4 * {Height}");
            sb.AppendLine($"P = {Perimeter:F2}");

            return sb.ToString();
        }

        public override void Draw(Graphics graphics)
        {
            var squareToDraw = new System.Drawing.Rectangle(
                Position.X,
                Position.Y,
                Width,
                Width);

            if (IsFilled)
            {
                graphics.FillRectangle(FillBrush, squareToDraw);
            }

            graphics.DrawRectangle(Border, squareToDraw);
        }

        public override string ToString()
        {
            return $"Square@{Height}x{Width}";
        }
    }
}
