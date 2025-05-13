using System;
using System.Drawing;

namespace MyPaint.Models
{
    [Serializable]
    public abstract class Shape
    {
        protected double Area { get; set; }

        protected double Perimeter { get; set; }

        public int Height { get; protected set; }

        public int Width { get; protected set; }

        public Point Position { get; set; }

        [field: NonSerialized]
        public Pen Border { get; set; } = new Pen(Color.Black);

        [field: NonSerialized]
        public SolidBrush FillBrush { get; set; } = new SolidBrush(Color.White);

        public bool IsFilled { get; set; }

        public virtual string ShowResult()
        {
            throw new NotImplementedException();
        }

        public bool Contains(Point point)
        {
            return
                Position.X <= point.X && (Position.X + Width) >= point.X &&
                Position.Y <= point.Y && (Position.Y + Height) >= point.Y;
        }

        public abstract void Draw(Graphics graphics);

        public System.Drawing.Rectangle GetBounds()
        {
            int borderWidth = (int)Border.Width + 5;

            return new System.Drawing.Rectangle(
                Position.X - borderWidth,
                Position.Y - borderWidth,
                Width + 2 * borderWidth,
                Height + 2 * borderWidth);
        }
    }
}
