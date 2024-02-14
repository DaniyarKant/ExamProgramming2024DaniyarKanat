using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point : IReflectable
    {
        public decimal X;
        public decimal Y;

        public Point(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }

        public Point(decimal x) : this(x, 0) { }

        public void ReflectX()
        {
            X = -X;
        }

        public void ReflectY()
        {
            Y = -Y;
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public virtual bool IsOnAxis => X == 0 || Y == 0;
    }

    public interface IReflectable
    {
        void ReflectX();
        void ReflectY();
    }

    public enum PointColour
    {
        Red,
        Green,
        Blue
    }

    public class ColourfulPoint : Point
    {
        public PointColour Colour { get; set; }

        public ColourfulPoint(decimal x, decimal y, PointColour colour) : base(x, y)
        {
            Colour = colour;
        }

        public void ChangeColour(PointColour newColour)
        {
            Colour = newColour;
        }

        public void NextColour()
        {
            Colour = (PointColour)(((int)Colour + 1) % Enum.GetNames(typeof(PointColour)).Length);
        }

        public void Normalize()
        {
            decimal magnitude = (decimal)Math.Sqrt((double)(X * X + Y * Y));
            if (magnitude != 0)
            {
                X /= magnitude;
                Y /= magnitude;
            }
        }

        public override string ToString()
        {
            return $"({X},{Y})";
        }

        public void Add(Point point)
        {
            X += point.X;
            Y += point.Y;
        }

        public static Point Add(Point point1, Point point2)
        {
            return new Point(point1.X + point2.X, point1.Y + point2.Y);
        }

        public override bool IsOnAxis => (X == 0 || Y == 0) && Colour == PointColour.Blue;
    }
}
