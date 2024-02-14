using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point : IReflectable
    {
        public decimal X { get; private set; }
        public decimal Y { get; private set; }

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
    }

    public interface IReflectable
    {
        void ReflectX();
        void ReflectY();
    }

   
}
