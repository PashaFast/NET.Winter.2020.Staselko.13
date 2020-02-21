using System;
using System.Collections.Generic;
using System.Text;

namespace BinarySearchAlgorithm
{
    public class Point : IComparable<Point>
    {
        public Point()
        {
            this.X = 0;
            this.Y = 0;
        }

        public Point(int x, int y)
        {
            this.X = x;
            this.Y = y;
        }

        public double X { get; set; }

        public double Y { get; set; }

        public int CompareTo(Point y)
        {
            if (this.X > y.X)
            {
                return 1;
            }

            if (this.X < y.X)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
