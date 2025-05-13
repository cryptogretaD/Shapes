using System;
using System.Drawing;
using System.Text;

namespace MyPaint.Models
{
    [Serializable]
    public class Circle : Shape
    {
        public Circle(int startPointX, int startPointY, int diameter)
        {
            Position = new Point(startPointX, startPointY);
            Width = Height = diameter;
            Area = (double)Height * Height * Math.PI;
            Perimeter = 2 * (double)Height * Math.PI;
        }
        
        public override string ShowResult()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("A = π * r^2");
            sb.AppendLine($"A = 3.14 * {Height}^2");
            sb.AppendLine($"A = {Area:F2}");

            sb.AppendLine("P = 2 * π * r");
            sb.AppendLine($"P = 2 * 3.14 * {Height}");
            sb.AppendLine($"P = {Perimeter:F2}");

            return sb.ToString();
        }

        public override void Draw(Graphics graphics)
        {
            var eclipseToDraw = new System.Drawing.Rectangle(
                Position.X,
                Position.Y,
                Height,
                Height);

            if (IsFilled)
            {
                graphics.FillEllipse(FillBrush, eclipseToDraw);
            }

            graphics.DrawEllipse(Border, eclipseToDraw);
        }

        public override string ToString()
        {
            return $"Circle@{Height}x{Width}";
        }
    }
}
