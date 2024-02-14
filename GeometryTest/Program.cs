using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Geometry;

namespace GeometryTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Point point1 = new Point(3, 4);
            Console.WriteLine($"Point1: {point1}");

            Point point2 = new Point(5);
            Console.WriteLine($"Point2: {point2}");

            Console.WriteLine($"Point1 is on axis: {point1.IsOnAxis}");
            Console.WriteLine($"Point2 is on axis: {point2.IsOnAxis}");

            point1.ReflectX();
            Console.WriteLine($"Reflected Point1: {point1}");

            ColourfulPoint cPoint1 = new ColourfulPoint(1, 2, PointColour.Red);
            Console.WriteLine($"ColourfulPoint1: {cPoint1}");

            ColourfulPoint cPoint2 = new ColourfulPoint(3, 4, PointColour.Blue);
            Console.WriteLine($"ColourfulPoint2: {cPoint2}");


            Console.WriteLine($"ColourfulPoint1 is on axis: {cPoint1.IsOnAxis}");
            Console.WriteLine($"ColourfulPoint2 is on axis: {cPoint2.IsOnAxis}");

            cPoint1.ChangeColour(PointColour.Green);
            Console.WriteLine($"Changed ColourfulPoint1 colour: {cPoint1.Colour}");

            Console.ReadKey();
        }

    }
}
