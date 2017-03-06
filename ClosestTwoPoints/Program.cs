using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClosestTwoPoints
{
    class Program
    {
        static void Main(string[] args)
        {
            int lines = int.Parse(Console.ReadLine());
            Point[] pointLines = new Point[lines];

            for (int i = 0; i < lines; i++)
            {
                pointLines[i] = ReadPoint();
            }
            
        }

        static Point ReadPoint()
        {
            int[] allP = Console.ReadLine().Split().Select(x => int.Parse(x)).ToArray();
            Point point = new Point();
            point.X = allP[0];
            point.Y = allP[1];
            return point;
        }

        static Point[] FindClosestPoint(Point[] pointLines)
        {
            return 
        }
    }

    class Point
    {
        public int X { get; set; }
        public int Y { get; set; }
    }
}
