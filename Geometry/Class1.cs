using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Geometry
{
    public class Point
    {
        public decimal X { get; }
        public decimal Y { get; }

        public Point(decimal x)
        {
            X = x;
            Y = 0;
        }

        public Point(decimal x, decimal y)
        {
            X = x;
            Y = y;
        }
    }
}
