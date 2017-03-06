using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceBnPoints
{
    class DistanceBnPoints
    {
        static void Main(string[] args)
        {
            Point point1 = ReadPoint();
            Point point2 = ReadPoint();

            double result = CalculatePointDistance(point1, point2);

            PrintPointDistance(result);


        }

        static Point ReadPoint()
        {
            int[] rawCoor = Console.ReadLine()
                .Split(' ')
                .Select(a => int.Parse(a))
                .ToArray();
            Point point = new Point();
            point.X = rawCoor[0];
            point.Y = rawCoor[1];
            return point;
        }

        static double CalculatePointDistance(Point p1, Point p2)
        {
            int a = p1.X - p2.X;
            int b = p1.Y - p2.Y;

            return Math.Sqrt(a * a + b * b);
        }

        static void PrintPointDistance(double clacResult)
        {
            Console.WriteLine("Distance: {0:f3}", clacResult);
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }

    }
}
