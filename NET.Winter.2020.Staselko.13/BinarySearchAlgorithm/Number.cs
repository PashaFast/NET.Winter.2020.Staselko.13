using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace BinarySearchAlgorithm
{
    public class Number : IComparer<Number>
    {
        public Number(int x)
        {
            this.X = x;
        }

        public Number()
        {
        }

        public int X { get; set; }

        public int Compare([AllowNull] Number x, [AllowNull] Number y)
        {
            if (x.X > y.X)
            {
                return 1;
            }

            if (x.X < y.X)
            {
                return -1;
            }

            return 0;
        }
    }
}
